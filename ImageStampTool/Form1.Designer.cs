namespace ImageStampTool
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            positionPanel = new System.Windows.Forms.Panel();
            positionBottomRight = new System.Windows.Forms.RadioButton();
            positionBottomLeft = new System.Windows.Forms.RadioButton();
            positionTopRight = new System.Windows.Forms.RadioButton();
            positionTopLeft = new System.Windows.Forms.RadioButton();
            modeLabel = new System.Windows.Forms.Label();
            radioModified = new System.Windows.Forms.RadioButton();
            radioTextbox = new System.Windows.Forms.RadioButton();
            radioDate = new System.Windows.Forms.RadioButton();
            labelposition = new System.Windows.Forms.Label();
            labelFont = new System.Windows.Forms.Label();
            fontDialog1 = new System.Windows.Forms.FontDialog();
            buttonFont = new System.Windows.Forms.Button();
            buttonNext = new System.Windows.Forms.Button();
            buttonPrev = new System.Windows.Forms.Button();
            labelColour = new System.Windows.Forms.Label();
            colorDialogOutline = new System.Windows.Forms.ColorDialog();
            colorDialogMain = new System.Windows.Forms.ColorDialog();
            buttonSave = new System.Windows.Forms.Button();
            labelMainColour = new System.Windows.Forms.Label();
            buttonMainColour = new System.Windows.Forms.Button();
            buttonOutline = new System.Windows.Forms.Button();
            labeloutline = new System.Windows.Forms.Label();
            labeloutlinesize = new System.Windows.Forms.Label();
            numericUpDownOutlineSize = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            textformat1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            comboBoxformat = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            folderPath = new System.Windows.Forms.TextBox();
            buttonOpenfolder = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            textBox1 = new System.Windows.Forms.TextBox();
            index = new System.Windows.Forms.NumericUpDown();
            label8 = new System.Windows.Forms.Label();
            buttonIndex = new System.Windows.Forms.Button();
            checkBoxtime = new System.Windows.Forms.CheckBox();
            domainformat = new System.Windows.Forms.ComboBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label6 = new System.Windows.Forms.Label();
            comboOutput = new System.Windows.Forms.ComboBox();
            labelExample = new System.Windows.Forms.Label();
            panelError = new System.Windows.Forms.Panel();
            labelError = new System.Windows.Forms.Label();
            timer3s = new System.Windows.Forms.Timer(components);
            positionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOutlineSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)index).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelError.SuspendLayout();
            SuspendLayout();
            // 
            // positionPanel
            // 
            positionPanel.BackColor = System.Drawing.Color.White;
            positionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            positionPanel.Controls.Add(positionBottomRight);
            positionPanel.Controls.Add(positionBottomLeft);
            positionPanel.Controls.Add(positionTopRight);
            positionPanel.Controls.Add(positionTopLeft);
            positionPanel.Location = new System.Drawing.Point(771, 130);
            positionPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            positionPanel.Name = "positionPanel";
            positionPanel.Size = new System.Drawing.Size(149, 110);
            positionPanel.TabIndex = 1;
            positionPanel.Paint += panel1_Paint;
            // 
            // positionBottomRight
            // 
            positionBottomRight.AutoSize = true;
            positionBottomRight.Checked = true;
            positionBottomRight.Location = new System.Drawing.Point(125, 88);
            positionBottomRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            positionBottomRight.Name = "positionBottomRight";
            positionBottomRight.Size = new System.Drawing.Size(14, 13);
            positionBottomRight.TabIndex = 3;
            positionBottomRight.TabStop = true;
            positionBottomRight.UseVisualStyleBackColor = true;
            positionBottomRight.Click += positionBottomRight_Click;
            // 
            // positionBottomLeft
            // 
            positionBottomLeft.AutoSize = true;
            positionBottomLeft.Location = new System.Drawing.Point(5, 88);
            positionBottomLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            positionBottomLeft.Name = "positionBottomLeft";
            positionBottomLeft.Size = new System.Drawing.Size(14, 13);
            positionBottomLeft.TabIndex = 2;
            positionBottomLeft.UseVisualStyleBackColor = true;
            positionBottomLeft.Click += positionBottomLeft_Click;
            // 
            // positionTopRight
            // 
            positionTopRight.AutoSize = true;
            positionTopRight.Location = new System.Drawing.Point(125, 5);
            positionTopRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            positionTopRight.Name = "positionTopRight";
            positionTopRight.Size = new System.Drawing.Size(14, 13);
            positionTopRight.TabIndex = 1;
            positionTopRight.UseVisualStyleBackColor = true;
            positionTopRight.Click += positionTopRight_Click;
            // 
            // positionTopLeft
            // 
            positionTopLeft.AutoSize = true;
            positionTopLeft.Location = new System.Drawing.Point(5, 5);
            positionTopLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            positionTopLeft.Name = "positionTopLeft";
            positionTopLeft.Size = new System.Drawing.Size(14, 13);
            positionTopLeft.TabIndex = 0;
            positionTopLeft.UseVisualStyleBackColor = true;
            positionTopLeft.Click += positionTopLeft_Click;
            // 
            // modeLabel
            // 
            modeLabel.AutoSize = true;
            modeLabel.Location = new System.Drawing.Point(768, 14);
            modeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modeLabel.Name = "modeLabel";
            modeLabel.Size = new System.Drawing.Size(41, 15);
            modeLabel.TabIndex = 2;
            modeLabel.Text = "Mode:";
            // 
            // radioModified
            // 
            radioModified.AutoSize = true;
            radioModified.Checked = true;
            radioModified.Location = new System.Drawing.Point(771, 33);
            radioModified.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioModified.Name = "radioModified";
            radioModified.Size = new System.Drawing.Size(170, 19);
            radioModified.TabIndex = 3;
            radioModified.TabStop = true;
            radioModified.Text = "Use this file's modified date";
            radioModified.UseVisualStyleBackColor = true;
            radioModified.CheckedChanged += radioModified_CheckedChanged;
            // 
            // radioTextbox
            // 
            radioTextbox.AutoSize = true;
            radioTextbox.Location = new System.Drawing.Point(771, 61);
            radioTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioTextbox.Name = "radioTextbox";
            radioTextbox.Size = new System.Drawing.Size(139, 19);
            radioTextbox.TabIndex = 4;
            radioTextbox.Text = "Use the following text";
            radioTextbox.UseVisualStyleBackColor = true;
            radioTextbox.CheckedChanged += radioTextbox_CheckedChanged;
            // 
            // radioDate
            // 
            radioDate.AutoSize = true;
            radioDate.Location = new System.Drawing.Point(771, 89);
            radioDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioDate.Name = "radioDate";
            radioDate.Size = new System.Drawing.Size(143, 19);
            radioDate.TabIndex = 5;
            radioDate.Text = "Use the following date";
            radioDate.UseVisualStyleBackColor = true;
            radioDate.CheckedChanged += radioDate_CheckedChanged;
            // 
            // labelposition
            // 
            labelposition.AutoSize = true;
            labelposition.Location = new System.Drawing.Point(768, 112);
            labelposition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelposition.Name = "labelposition";
            labelposition.Size = new System.Drawing.Size(90, 15);
            labelposition.TabIndex = 7;
            labelposition.Text = "Stamp position:";
            // 
            // labelFont
            // 
            labelFont.AutoSize = true;
            labelFont.Location = new System.Drawing.Point(769, 249);
            labelFont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFont.Name = "labelFont";
            labelFont.Size = new System.Drawing.Size(34, 15);
            labelFont.TabIndex = 8;
            labelFont.Text = "Font:";
            // 
            // fontDialog1
            // 
            fontDialog1.Font = new System.Drawing.Font("Courier New", 72F, System.Drawing.FontStyle.Bold);
            // 
            // buttonFont
            // 
            buttonFont.Location = new System.Drawing.Point(771, 269);
            buttonFont.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonFont.Name = "buttonFont";
            buttonFont.Size = new System.Drawing.Size(541, 27);
            buttonFont.TabIndex = 9;
            buttonFont.Text = "Courier New, 72pt, Bold";
            buttonFont.UseVisualStyleBackColor = true;
            buttonFont.TextChanged += buttonFont_TextChanged;
            buttonFont.Click += buttonFont_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new System.Drawing.Point(1225, 541);
            buttonNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new System.Drawing.Size(88, 27);
            buttonNext.TabIndex = 10;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonPrev
            // 
            buttonPrev.Location = new System.Drawing.Point(772, 541);
            buttonPrev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new System.Drawing.Size(88, 27);
            buttonPrev.TabIndex = 11;
            buttonPrev.Text = "Previous";
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // labelColour
            // 
            labelColour.AutoSize = true;
            labelColour.Location = new System.Drawing.Point(771, 299);
            labelColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelColour.Name = "labelColour";
            labelColour.Size = new System.Drawing.Size(78, 15);
            labelColour.TabIndex = 12;
            labelColour.Text = "Font settings:";
            labelColour.Click += labelColour_Click;
            // 
            // colorDialogMain
            // 
            colorDialogMain.Color = System.Drawing.Color.White;
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(1000, 541);
            buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(88, 27);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelMainColour
            // 
            labelMainColour.AutoSize = true;
            labelMainColour.Location = new System.Drawing.Point(771, 320);
            labelMainColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMainColour.Name = "labelMainColour";
            labelMainColour.Size = new System.Drawing.Size(74, 15);
            labelMainColour.TabIndex = 14;
            labelMainColour.Text = "Main colour:";
            // 
            // buttonMainColour
            // 
            buttonMainColour.Location = new System.Drawing.Point(847, 317);
            buttonMainColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonMainColour.Name = "buttonMainColour";
            buttonMainColour.Size = new System.Drawing.Size(88, 23);
            buttonMainColour.TabIndex = 15;
            buttonMainColour.UseVisualStyleBackColor = true;
            buttonMainColour.BackColorChanged += buttonMainColour_BackColorChanged;
            buttonMainColour.Click += buttonMainColour_Click;
            // 
            // buttonOutline
            // 
            buttonOutline.BackColor = System.Drawing.Color.Black;
            buttonOutline.Location = new System.Drawing.Point(1022, 317);
            buttonOutline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonOutline.Name = "buttonOutline";
            buttonOutline.Size = new System.Drawing.Size(88, 23);
            buttonOutline.TabIndex = 17;
            buttonOutline.UseVisualStyleBackColor = false;
            buttonOutline.BackColorChanged += buttonOutline_BackColorChanged;
            buttonOutline.Click += buttonOutline_Click;
            // 
            // labeloutline
            // 
            labeloutline.AutoSize = true;
            labeloutline.Location = new System.Drawing.Point(938, 320);
            labeloutline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labeloutline.Name = "labeloutline";
            labeloutline.Size = new System.Drawing.Size(86, 15);
            labeloutline.TabIndex = 16;
            labeloutline.Text = "Outline colour:";
            // 
            // labeloutlinesize
            // 
            labeloutlinesize.AutoSize = true;
            labeloutlinesize.Location = new System.Drawing.Point(1116, 320);
            labeloutlinesize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labeloutlinesize.Name = "labeloutlinesize";
            labeloutlinesize.Size = new System.Drawing.Size(101, 15);
            labeloutlinesize.TabIndex = 18;
            labeloutlinesize.Text = "Outline thickness:";
            // 
            // numericUpDownOutlineSize
            // 
            numericUpDownOutlineSize.Location = new System.Drawing.Point(1225, 317);
            numericUpDownOutlineSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericUpDownOutlineSize.Name = "numericUpDownOutlineSize";
            numericUpDownOutlineSize.Size = new System.Drawing.Size(88, 23);
            numericUpDownOutlineSize.TabIndex = 19;
            numericUpDownOutlineSize.Value = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDownOutlineSize.ValueChanged += numericUpDownOutlineSize_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(771, 344);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 15);
            label1.TabIndex = 20;
            label1.Text = "File name format:";
            // 
            // textformat1
            // 
            textformat1.Location = new System.Drawing.Point(820, 362);
            textformat1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textformat1.Name = "textformat1";
            textformat1.Size = new System.Drawing.Size(116, 23);
            textformat1.TabIndex = 22;
            textformat1.Text = "IMG_";
            textformat1.TextChanged += textformat1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(771, 368);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 15);
            label2.TabIndex = 23;
            label2.Text = "Prefix:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(771, 392);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 15);
            label3.TabIndex = 24;
            label3.Text = "How many digits?:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(772, 420);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 15);
            label4.TabIndex = 25;
            label4.Text = "Extension:";
            // 
            // comboBoxformat
            // 
            comboBoxformat.FormattingEnabled = true;
            comboBoxformat.Items.AddRange(new object[] { ".JPG", ".JPEG", ".TIF", ".TIFF", ".PNG", ".BMP", ".GIF" });
            comboBoxformat.Location = new System.Drawing.Point(845, 417);
            comboBoxformat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBoxformat.Name = "comboBoxformat";
            comboBoxformat.Size = new System.Drawing.Size(140, 23);
            comboBoxformat.TabIndex = 26;
            comboBoxformat.Text = ".JPG";
            comboBoxformat.SelectedIndexChanged += comboBoxformat_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(772, 449);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 15);
            label5.TabIndex = 27;
            label5.Text = "Folder:";
            // 
            // folderPath
            // 
            folderPath.Location = new System.Drawing.Point(820, 444);
            folderPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            folderPath.Name = "folderPath";
            folderPath.Size = new System.Drawing.Size(467, 23);
            folderPath.TabIndex = 28;
            // 
            // buttonOpenfolder
            // 
            buttonOpenfolder.Location = new System.Drawing.Point(1282, 443);
            buttonOpenfolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonOpenfolder.Name = "buttonOpenfolder";
            buttonOpenfolder.Size = new System.Drawing.Size(29, 27);
            buttonOpenfolder.TabIndex = 29;
            buttonOpenfolder.Text = "...";
            buttonOpenfolder.UseVisualStyleBackColor = true;
            buttonOpenfolder.Click += buttonOpenfolder_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new System.Drawing.Point(930, 89);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(233, 23);
            dateTimePicker1.TabIndex = 30;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new System.Drawing.Point(930, 60);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(233, 23);
            textBox1.TabIndex = 33;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // index
            // 
            index.Location = new System.Drawing.Point(820, 503);
            index.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            index.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            index.Name = "index";
            index.Size = new System.Drawing.Size(140, 23);
            index.TabIndex = 35;
            index.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(775, 508);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(38, 15);
            label8.TabIndex = 36;
            label8.Text = "Index:";
            // 
            // buttonIndex
            // 
            buttonIndex.Location = new System.Drawing.Point(967, 502);
            buttonIndex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonIndex.Name = "buttonIndex";
            buttonIndex.Size = new System.Drawing.Size(88, 27);
            buttonIndex.TabIndex = 37;
            buttonIndex.Text = "Load";
            buttonIndex.UseVisualStyleBackColor = true;
            buttonIndex.Click += buttonIndex_Click;
            // 
            // checkBoxtime
            // 
            checkBoxtime.AutoSize = true;
            checkBoxtime.Location = new System.Drawing.Point(955, 33);
            checkBoxtime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxtime.Name = "checkBoxtime";
            checkBoxtime.Size = new System.Drawing.Size(90, 19);
            checkBoxtime.TabIndex = 38;
            checkBoxtime.Text = "Show Time?";
            checkBoxtime.UseVisualStyleBackColor = true;
            checkBoxtime.CheckedChanged += checkBoxtime_CheckedChanged;
            // 
            // domainformat
            // 
            domainformat.FormattingEnabled = true;
            domainformat.Items.AddRange(new object[] { "No number format", "1", "2", "3", "4", "5", "6", "7", "8" });
            domainformat.Location = new System.Drawing.Point(884, 389);
            domainformat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            domainformat.Name = "domainformat";
            domainformat.Size = new System.Drawing.Size(140, 23);
            domainformat.TabIndex = 39;
            domainformat.Text = "4";
            domainformat.SelectedIndexChanged += domainformat_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Black;
            pictureBox1.BackgroundImage = Properties.Resources.preview1;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(14, 14);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(747, 554);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(775, 478);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(87, 15);
            label6.TabIndex = 41;
            label6.Text = "Output format:";
            // 
            // comboOutput
            // 
            comboOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboOutput.FormattingEnabled = true;
            comboOutput.Items.AddRange(new object[] { "JPEG", "PNG", "TIFF", "BITMAP" });
            comboOutput.Location = new System.Drawing.Point(868, 473);
            comboOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboOutput.Name = "comboOutput";
            comboOutput.Size = new System.Drawing.Size(140, 23);
            comboOutput.TabIndex = 42;
            // 
            // labelExample
            // 
            labelExample.AutoSize = true;
            labelExample.Location = new System.Drawing.Point(1032, 392);
            labelExample.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelExample.Name = "labelExample";
            labelExample.Size = new System.Drawing.Size(130, 15);
            labelExample.TabIndex = 43;
            labelExample.Text = "Example: IMG_0005.JPG";
            // 
            // panelError
            // 
            panelError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panelError.Controls.Add(labelError);
            panelError.Location = new System.Drawing.Point(526, 249);
            panelError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelError.Name = "panelError";
            panelError.Size = new System.Drawing.Size(353, 115);
            panelError.TabIndex = 44;
            panelError.Visible = false;
            // 
            // labelError
            // 
            labelError.Dock = System.Windows.Forms.DockStyle.Fill;
            labelError.Location = new System.Drawing.Point(0, 0);
            labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelError.Name = "labelError";
            labelError.Size = new System.Drawing.Size(349, 111);
            labelError.TabIndex = 0;
            labelError.Text = "Pop-up dialogue";
            labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer3s
            // 
            timer3s.Interval = 3000;
            timer3s.Tick += timer3s_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1326, 590);
            Controls.Add(panelError);
            Controls.Add(labelExample);
            Controls.Add(comboOutput);
            Controls.Add(label6);
            Controls.Add(domainformat);
            Controls.Add(checkBoxtime);
            Controls.Add(buttonIndex);
            Controls.Add(label8);
            Controls.Add(index);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonOpenfolder);
            Controls.Add(folderPath);
            Controls.Add(label5);
            Controls.Add(comboBoxformat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textformat1);
            Controls.Add(label1);
            Controls.Add(numericUpDownOutlineSize);
            Controls.Add(labeloutlinesize);
            Controls.Add(buttonOutline);
            Controls.Add(labeloutline);
            Controls.Add(buttonMainColour);
            Controls.Add(labelMainColour);
            Controls.Add(buttonSave);
            Controls.Add(labelColour);
            Controls.Add(buttonPrev);
            Controls.Add(buttonNext);
            Controls.Add(buttonFont);
            Controls.Add(labelFont);
            Controls.Add(labelposition);
            Controls.Add(radioDate);
            Controls.Add(radioTextbox);
            Controls.Add(radioModified);
            Controls.Add(modeLabel);
            Controls.Add(positionPanel);
            Controls.Add(pictureBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1342, 629);
            MinimumSize = new System.Drawing.Size(1342, 629);
            Name = "Form1";
            Text = "Image Stamp Tool";
            Load += Form1_Load;
            positionPanel.ResumeLayout(false);
            positionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOutlineSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)index).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelError.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel positionPanel;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.RadioButton radioModified;
        private System.Windows.Forms.RadioButton radioTextbox;
        private System.Windows.Forms.RadioButton radioDate;
        private System.Windows.Forms.RadioButton positionBottomRight;
        private System.Windows.Forms.RadioButton positionBottomLeft;
        private System.Windows.Forms.RadioButton positionTopRight;
        private System.Windows.Forms.RadioButton positionTopLeft;
        private System.Windows.Forms.Label labelposition;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label labelColour;
        private System.Windows.Forms.ColorDialog colorDialogOutline;
        private System.Windows.Forms.ColorDialog colorDialogMain;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelMainColour;
        private System.Windows.Forms.Button buttonMainColour;
        private System.Windows.Forms.Button buttonOutline;
        private System.Windows.Forms.Label labeloutline;
        private System.Windows.Forms.Label labeloutlinesize;
        private System.Windows.Forms.NumericUpDown numericUpDownOutlineSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textformat1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxformat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button buttonOpenfolder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown index;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonIndex;
        private System.Windows.Forms.CheckBox checkBoxtime;
        private System.Windows.Forms.ComboBox domainformat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboOutput;
        private System.Windows.Forms.Label labelExample;
        private System.Windows.Forms.Panel panelError;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Timer timer3s;
    }
}

