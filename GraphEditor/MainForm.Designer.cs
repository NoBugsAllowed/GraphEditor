using System.Resources;

namespace GraphEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanelWindow = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxLang = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelLang = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPolish = new System.Windows.Forms.Button();
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.groupBoxImportExport = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelImportExport = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelEdit = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDeleteV = new System.Windows.Forms.Button();
            this.tableLayoutPanelColor = new System.Windows.Forms.TableLayoutPanel();
            this.buttonColor = new System.Windows.Forms.Button();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanelWindow.SuspendLayout();
            this.tableLayoutPanelRight.SuspendLayout();
            this.groupBoxLang.SuspendLayout();
            this.tableLayoutPanelLang.SuspendLayout();
            this.groupBoxImportExport.SuspendLayout();
            this.tableLayoutPanelImportExport.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.tableLayoutPanelEdit.SuspendLayout();
            this.tableLayoutPanelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelWindow
            // 
            resources.ApplyResources(this.tableLayoutPanelWindow, "tableLayoutPanelWindow");
            this.tableLayoutPanelWindow.Controls.Add(this.tableLayoutPanelRight, 1, 0);
            this.tableLayoutPanelWindow.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanelWindow.Name = "tableLayoutPanelWindow";
            // 
            // tableLayoutPanelRight
            // 
            resources.ApplyResources(this.tableLayoutPanelRight, "tableLayoutPanelRight");
            this.tableLayoutPanelRight.Controls.Add(this.groupBoxLang, 0, 1);
            this.tableLayoutPanelRight.Controls.Add(this.groupBoxImportExport, 0, 2);
            this.tableLayoutPanelRight.Controls.Add(this.groupBoxEdit, 0, 0);
            this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            // 
            // groupBoxLang
            // 
            resources.ApplyResources(this.groupBoxLang, "groupBoxLang");
            this.groupBoxLang.Controls.Add(this.tableLayoutPanelLang);
            this.groupBoxLang.Name = "groupBoxLang";
            this.groupBoxLang.TabStop = false;
            // 
            // tableLayoutPanelLang
            // 
            resources.ApplyResources(this.tableLayoutPanelLang, "tableLayoutPanelLang");
            this.tableLayoutPanelLang.Controls.Add(this.buttonPolish, 0, 0);
            this.tableLayoutPanelLang.Controls.Add(this.buttonEnglish, 0, 1);
            this.tableLayoutPanelLang.Name = "tableLayoutPanelLang";
            // 
            // buttonPolish
            // 
            resources.ApplyResources(this.buttonPolish, "buttonPolish");
            this.buttonPolish.Name = "buttonPolish";
            this.buttonPolish.UseVisualStyleBackColor = true;
            this.buttonPolish.Click += new System.EventHandler(this.buttonPolish_Click);
            // 
            // buttonEnglish
            // 
            resources.ApplyResources(this.buttonEnglish, "buttonEnglish");
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.UseVisualStyleBackColor = true;
            this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
            // 
            // groupBoxImportExport
            // 
            resources.ApplyResources(this.groupBoxImportExport, "groupBoxImportExport");
            this.groupBoxImportExport.Controls.Add(this.tableLayoutPanelImportExport);
            this.groupBoxImportExport.Name = "groupBoxImportExport";
            this.groupBoxImportExport.TabStop = false;
            // 
            // tableLayoutPanelImportExport
            // 
            resources.ApplyResources(this.tableLayoutPanelImportExport, "tableLayoutPanelImportExport");
            this.tableLayoutPanelImportExport.Controls.Add(this.buttonSave, 0, 0);
            this.tableLayoutPanelImportExport.Controls.Add(this.buttonLoad, 0, 1);
            this.tableLayoutPanelImportExport.Name = "tableLayoutPanelImportExport";
            // 
            // buttonSave
            // 
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            resources.ApplyResources(this.buttonLoad, "buttonLoad");
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBoxEdit
            // 
            resources.ApplyResources(this.groupBoxEdit, "groupBoxEdit");
            this.groupBoxEdit.Controls.Add(this.tableLayoutPanelEdit);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.TabStop = false;
            // 
            // tableLayoutPanelEdit
            // 
            resources.ApplyResources(this.tableLayoutPanelEdit, "tableLayoutPanelEdit");
            this.tableLayoutPanelEdit.Controls.Add(this.buttonClear, 0, 2);
            this.tableLayoutPanelEdit.Controls.Add(this.buttonDeleteV, 0, 1);
            this.tableLayoutPanelEdit.Controls.Add(this.tableLayoutPanelColor, 0, 0);
            this.tableLayoutPanelEdit.Name = "tableLayoutPanelEdit";
            // 
            // buttonClear
            // 
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDeleteV
            // 
            resources.ApplyResources(this.buttonDeleteV, "buttonDeleteV");
            this.buttonDeleteV.Name = "buttonDeleteV";
            this.buttonDeleteV.UseVisualStyleBackColor = true;
            this.buttonDeleteV.Click += new System.EventHandler(this.buttonDeleteV_Click);
            // 
            // tableLayoutPanelColor
            // 
            resources.ApplyResources(this.tableLayoutPanelColor, "tableLayoutPanelColor");
            this.tableLayoutPanelColor.Controls.Add(this.buttonColor, 0, 0);
            this.tableLayoutPanelColor.Controls.Add(this.pictureBoxColor, 1, 0);
            this.tableLayoutPanelColor.Name = "tableLayoutPanelColor";
            // 
            // buttonColor
            // 
            resources.ApplyResources(this.buttonColor, "buttonColor");
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // pictureBoxColor
            // 
            resources.ApplyResources(this.pictureBoxColor, "pictureBoxColor");
            this.pictureBoxColor.BackColor = System.Drawing.Color.Black;
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.TabStop = false;
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // saveFileDialog
            // 
            resources.ApplyResources(this.saveFileDialog, "saveFileDialog");
            // 
            // openFileDialog
            // 
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelWindow);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.tableLayoutPanelWindow.ResumeLayout(false);
            this.tableLayoutPanelRight.ResumeLayout(false);
            this.groupBoxLang.ResumeLayout(false);
            this.tableLayoutPanelLang.ResumeLayout(false);
            this.groupBoxImportExport.ResumeLayout(false);
            this.tableLayoutPanelImportExport.ResumeLayout(false);
            this.groupBoxEdit.ResumeLayout(false);
            this.tableLayoutPanelEdit.ResumeLayout(false);
            this.tableLayoutPanelColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWindow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
        private System.Windows.Forms.GroupBox groupBoxLang;
        private System.Windows.Forms.GroupBox groupBoxImportExport;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLang;
        private System.Windows.Forms.Button buttonPolish;
        private System.Windows.Forms.Button buttonEnglish;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelImportExport;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEdit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDeleteV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelColor;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

