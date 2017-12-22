using System.Collections.Generic;

namespace Imprivata
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sortedMergeTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pangramTest = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.lstTestStrings = new System.Windows.Forms.ListBox();
            this.pangramTestInput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TopmostStep = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.cityClinicsTest = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.outputWindowManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outputWindow = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.sortedMergeTab.SuspendLayout();
            this.pangramTest.SuspendLayout();
            this.TopmostStep.SuspendLayout();
            this.cityClinicsTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputWindowManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sortedMergeTab);
            this.tabControl1.Controls.Add(this.pangramTest);
            this.tabControl1.Controls.Add(this.TopmostStep);
            this.tabControl1.Controls.Add(this.cityClinicsTest);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 236);
            this.tabControl1.TabIndex = 0;
            // 
            // sortedMergeTab
            // 
            this.sortedMergeTab.Controls.Add(this.button1);
            this.sortedMergeTab.Location = new System.Drawing.Point(8, 39);
            this.sortedMergeTab.Name = "sortedMergeTab";
            this.sortedMergeTab.Padding = new System.Windows.Forms.Padding(3);
            this.sortedMergeTab.Size = new System.Drawing.Size(951, 189);
            this.sortedMergeTab.TabIndex = 0;
            this.sortedMergeTab.Text = "Merge Strings and Sort";
            this.sortedMergeTab.UseVisualStyleBackColor = true;
            this.sortedMergeTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run Merge TestfoundLetters[testString.ElementAt(i)]";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pangramTest
            // 
            this.pangramTest.Controls.Add(this.button5);
            this.pangramTest.Controls.Add(this.lstTestStrings);
            this.pangramTest.Controls.Add(this.pangramTestInput);
            this.pangramTest.Controls.Add(this.button2);
            this.pangramTest.Location = new System.Drawing.Point(8, 39);
            this.pangramTest.Name = "pangramTest";
            this.pangramTest.Padding = new System.Windows.Forms.Padding(3);
            this.pangramTest.Size = new System.Drawing.Size(951, 189);
            this.pangramTest.TabIndex = 1;
            this.pangramTest.Text = "Pangram Test";
            this.pangramTest.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(694, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 46);
            this.button5.TabIndex = 6;
            this.button5.Text = "Pangran Test";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lstTestStrings
            // 
            this.lstTestStrings.FormattingEnabled = true;
            this.lstTestStrings.ItemHeight = 25;
            this.lstTestStrings.Items.AddRange(new object[] {
            "The quick brown fox jumps over the lazy dog",
            "We promptly judged antique ivory buckles for the next prize    ",
            "We promptly judged antique ivory buckles for the prize    "});
            this.lstTestStrings.Location = new System.Drawing.Point(9, 8);
            this.lstTestStrings.Name = "lstTestStrings";
            this.lstTestStrings.Size = new System.Drawing.Size(679, 79);
            this.lstTestStrings.TabIndex = 5;
            // 
            // pangramTestInput
            // 
            this.pangramTestInput.Location = new System.Drawing.Point(4, 117);
            this.pangramTestInput.MaxLength = 103;
            this.pangramTestInput.Name = "pangramTestInput";
            this.pangramTestInput.Size = new System.Drawing.Size(682, 31);
            this.pangramTestInput.TabIndex = 4;
            this.pangramTestInput.Text = "FREE FORM ENTRY";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pangran Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // TopmostStep
            // 
            this.TopmostStep.Controls.Add(this.button3);
            this.TopmostStep.Location = new System.Drawing.Point(8, 39);
            this.TopmostStep.Name = "TopmostStep";
            this.TopmostStep.Size = new System.Drawing.Size(951, 189);
            this.TopmostStep.TabIndex = 2;
            this.TopmostStep.Text = "topmostStepTest";
            this.TopmostStep.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Topmost Step Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // cityClinicsTest
            // 
            this.cityClinicsTest.Controls.Add(this.button4);
            this.cityClinicsTest.Location = new System.Drawing.Point(8, 39);
            this.cityClinicsTest.Name = "cityClinicsTest";
            this.cityClinicsTest.Size = new System.Drawing.Size(951, 189);
            this.cityClinicsTest.TabIndex = 3;
            this.cityClinicsTest.Text = "City Clinics Test";
            this.cityClinicsTest.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 41);
            this.button4.TabIndex = 5;
            this.button4.Text = "City Clinic Test";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // outputWindowManagerBindingSource
            // 
            this.outputWindowManagerBindingSource.DataSource = typeof(System.Collections.Generic.IList<string>);
            // 
            // outputWindow
            // 
            this.outputWindow.Location = new System.Drawing.Point(12, 242);
            this.outputWindow.Multiline = true;
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.Size = new System.Drawing.Size(929, 593);
            this.outputWindow.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 840);
            this.Controls.Add(this.outputWindow);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.sortedMergeTab.ResumeLayout(false);
            this.pangramTest.ResumeLayout(false);
            this.pangramTest.PerformLayout();
            this.TopmostStep.ResumeLayout(false);
            this.cityClinicsTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outputWindowManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sortedMergeTab;
        private System.Windows.Forms.TabPage pangramTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage TopmostStep;
        private System.Windows.Forms.TabPage cityClinicsTest;
        private System.Windows.Forms.TextBox pangramTestInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource outputWindowManagerBindingSource;
        private System.Windows.Forms.TextBox outputWindow;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox lstTestStrings;
    }
}

