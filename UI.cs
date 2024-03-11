using DARtoOAR.Components;
using NLog;

namespace DARtoOAR {
    public partial class UI : Form {
        private static readonly Logger LOGGER = LogManager.GetCurrentClassLogger();
        private static string DEFAULT_FOLDER_PATH = @"c:\Users";

        public UI() {
            InitializeComponent();
        }

        private void UI_Load(object sender, EventArgs e) {
        }

        private void darFolderPickerBtn_Click(object sender, EventArgs e) {
            var darFolderDlg = new FolderPicker();
            darFolderDlg.InputPath = DEFAULT_FOLDER_PATH;
            if (darFolderDlg.ShowDialog(darFolderPickerBtn.Handle) == true) {
                darModFolderPath.Text = darFolderDlg.ResultPath;
            }
        }

        private async void convertBtn_Click(object sender, EventArgs e) {
            var converted = new List<string>();
            try {
                var mo2ModsPath = darModFolderPath.Text;
                var mods = Directory.GetDirectories(mo2ModsPath);
                foreach (var modPath in mods) {
                    LOGGER.Info("Mod found: " + modPath);
                    var modName = new DirectoryInfo(modPath).Name;
                    var conditionPath = Path.Join(modPath, "Meshes\\actors\\character\\animations\\DynamicAnimationReplacer\\_CustomConditions");
                    if (Directory.Exists(conditionPath)) {
                        LOGGER.Info("Converting " + modName);
                        var darPath = Path.Join(modPath, "Meshes\\actors\\character\\animations\\DynamicAnimationReplacer");
                        var darNewPath = Path.Join(modPath, "Meshes\\actors\\character\\animations\\.DynamicAnimationReplacer");
                        await Converter.convertDARtoOAR(modPath, modPath, modName, "");
                        Directory.Move(darPath, darNewPath);


                        var _1stPath = Path.Join(modPath, @"Meshes\actors\character\_1stperson\animations\DynamicAnimationReplacer");
                        var _1stNewPath = Path.Join(modPath, @"Meshes\actors\character\_1stperson\animations\.DynamicAnimationReplacer");
                        var _1stConditionPath = Path.Join(modPath, @"Meshes\actors\character\_1stperson\animations\DynamicAnimationReplacer\_CustomConditions");
                        var _1stConvertedPath = Path.Join(modPath, @"Meshes\actors\character\_1stperson\animations\OpenAnimationReplacer");
                        if (Directory.Exists(_1stConditionPath) && Directory.Exists(_1stConvertedPath)) {
                            Directory.Move(_1stPath, _1stNewPath);
                        }                        

                        converted.Add(modName);
                    }
                }
                MessageBox.Show($"Conversion {converted.Count} mods ({string.Join(", ", converted)}) successful!");
            } catch (Exception ex) {
                LOGGER.Error(ex);
                MessageBox.Show($"Error aborted! Converted: {string.Join(", ", converted)}!");
            }
        }
    }
}