using System.Diagnostics;
using System.Text;

namespace PhotosUpdateLensModel
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            txtPhotos.Text = "C:\\Working\\Photos\\20250204\\TEST";
        }

        private void btnBrowsePhotos_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select Photos folder";
                folderDialog.UseDescriptionForTitle = true;

                // Set initial directory if current path is valid
                if (!string.IsNullOrWhiteSpace(txtPhotos.Text) && Directory.Exists(txtPhotos.Text))
                {
                    folderDialog.InitialDirectory = txtPhotos.Text;
                }

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPhotos.Text = folderDialog.SelectedPath;
                }
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            // Validate path
            if (string.IsNullOrWhiteSpace(txtPhotos.Text) || !Directory.Exists(txtPhotos.Text))
            {
                MessageBox.Show("Please select a valid Photos folder.", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                btnStart.Enabled = false;
                toolStripStatusLabel1.Text = "Processing...";
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee;

                string exiftoolPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExifTool", "exiftool.exe");
                if (!File.Exists(exiftoolPath))
                {
                    MessageBox.Show("ExifTool executable not found in the selected folder.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create process info for ExifTool
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = exiftoolPath,
                    Arguments = $"-overwrite_original " + // Add this to overwrite originals
                                $"-r -ext jpg -ext jpeg " +
                                $"-if \"not $LensModel or $LensModel eq ''\" " +
                                $"-tagsfromfile @ " +
                                $"-if \"$Lens\" \"-LensModel<$Lens\" " +
                                $"-if \"$LensSpec\" \"-LensModel<$LensSpec\" " +
                                $"-if \"$LensID\" \"-LensModel<$LensID\" " +
                                $"\"{txtPhotos.Text}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = startInfo })
                {
                    StringBuilder output = new StringBuilder();
                    StringBuilder error = new StringBuilder();

                    process.OutputDataReceived += (s, args) =>
                    {
                        if (args.Data != null)
                        {
                            output.AppendLine(args.Data);
                        }
                    };

                    process.ErrorDataReceived += (s, args) =>
                    {
                        if (args.Data != null)
                        {
                            error.AppendLine(args.Data);
                        }
                    };

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    await process.WaitForExitAsync();

                    if (process.ExitCode != 0)
                    {
                        // Exit code 2 means no files were modified (which is OK)
                        if (process.ExitCode == 2)
                        {
                            toolStripStatusLabel1.Text = "No files needed updating";
                            MessageBox.Show("No files needed updating. All files already have LensModel set.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Error processing files:\n{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Completed successfully";
                        MessageBox.Show("Process completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel1.Text = "Error occurred";
            }
            finally
            {
                btnStart.Enabled = true;
                toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
            }
        }
    }
}
