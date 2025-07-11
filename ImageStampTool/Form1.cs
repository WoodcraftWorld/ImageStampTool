using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Microsoft.Win32;

namespace ImageStampTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            comboOutput.SelectedIndex = 0;


        }
        public int IsNewProc = 0;
        public string Title = "Image Stamp Tool";
        private void StampFrame(string imagePath, string text)
        {

            Image originalImage = Image.FromFile(imagePath);
            Bitmap bitmap = new Bitmap(originalImage);


            using (Graphics g = Graphics.FromImage(bitmap))
            {
                int position;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                if (positionTopLeft.Checked)
                {
                    position = 0;
                }
                else if (positionTopRight.Checked)
                {
                    position = 1;
                }
                else if (positionBottomLeft.Checked)
                {
                    position = 2;
                }
                else if (positionBottomRight.Checked)
                {
                    position = 3;
                }
                else
                {
                    throw new Exception();
                }
                Font font = fontDialog1.Font;
                int padding = 60;

                // Set up alignment and position
                StringFormat format = new StringFormat();
                float x = padding;
                float y = padding;

                switch (position)
                {
                    case 0:
                        format.Alignment = StringAlignment.Near;
                        format.LineAlignment = StringAlignment.Near;
                        break;

                    case 1:
                        format.Alignment = StringAlignment.Far;
                        format.LineAlignment = StringAlignment.Near;
                        break;

                    case 2:
                        format.Alignment = StringAlignment.Near;
                        format.LineAlignment = StringAlignment.Far;
                        y = bitmap.Height - font.Height - padding;
                        break;

                    case 3:
                    default:
                        format.Alignment = StringAlignment.Far;
                        format.LineAlignment = StringAlignment.Far;
                        y = bitmap.Height - font.Height - padding;
                        break;
                }

                RectangleF layoutRect = new RectangleF(
                    padding,
                    padding,
                    bitmap.Width - 2 * padding,
                    bitmap.Height - 2 * padding
                );

                // Outline
                Color outlineColor = buttonOutline.BackColor;
                Color fillColor = buttonMainColour.BackColor;
                int outlineWidth = Convert.ToInt32(numericUpDownOutlineSize.Value);

                for (int dx = -outlineWidth; dx <= outlineWidth; dx++)
                {
                    for (int dy = -outlineWidth; dy <= outlineWidth; dy++)
                    {
                        if (dx != 0 || dy != 0)
                        {
                            RectangleF offsetRect = new RectangleF(
                                layoutRect.X + dx,
                                layoutRect.Y + dy,
                                layoutRect.Width,
                                layoutRect.Height
                            );
                            g.DrawString(text, font, new SolidBrush(outlineColor), offsetRect, format);
                        }
                    }
                }

                // Main text
                g.DrawString(text, font, new SolidBrush(fillColor), layoutRect, format);
            }

            pictureBox1.BackgroundImage = bitmap;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            buttonFont.Text = fontDialog1.Font.Name + ", " + fontDialog1.Font.Size.ToString() + "pt, " + fontDialog1.Font.Style.ToString();
            Console.WriteLine(buttonFont.Text);
            LoadImage();
            // MessageBox.Show("Font");
        }

        private void labelColour_Click(object sender, EventArgs e)
        {

        }

        private void buttonOutline_Click(object sender, EventArgs e)
        {
            colorDialogOutline.ShowDialog();
            buttonOutline.BackColor = colorDialogOutline.Color;
        }

        private void buttonMainColour_Click(object sender, EventArgs e)
        {
            colorDialogMain.ShowDialog();
            buttonMainColour.BackColor = colorDialogMain.Color;
        }

        private void buttonOpenfolder_Click(object sender, EventArgs e)
        {
            var dlg = new System.Windows.Forms.FolderBrowserDialog();
            dlg.Description = "Select a folder";


            if (dlg.ShowDialog() == DialogResult.OK)
            {
                folderPath.Text = dlg.SelectedPath;
            }
        }

        private void buttonIndex_Click(object sender, EventArgs e)
        {
            LoadImage();

        }
        private void LoadImage()
        {
            this.Text = Title;

            string digits = "";
            try
            {
                Convert.ToInt32(domainformat.Text);
                digits = Convert.ToInt32(index.Value).ToString("D" + domainformat.Text);
            }
            catch
            {
                digits = index.Value.ToString();
            }
            string FilePth = folderPath.Text + "\\" + textformat1.Text + digits + comboBoxformat.Text;
            //MessageBox.Show(FilePth);
            string theText = "Error";
            if (radioModified.Checked)
            {
                FileInfo imageInput = new FileInfo(FilePth);
                DateTime modifiedDate = imageInput.LastWriteTime;
                theText = modifiedDate.ToString();
                if (!checkBoxtime.Checked)
                {
                    theText = modifiedDate.ToString("d");
                }
            }
            else if (radioTextbox.Checked)
            {
                theText = textBox1.Text;
            }
            else if (radioDate.Checked)
            {
                theText = dateTimePicker1.Value.ToString("d");
            }
            try
            {
                StampFrame(FilePth, theText);
                this.Text = Title + " - " + FilePth;
            }
            catch (Exception)
            {
                showPopUp("Error! File does not Exist! ensure to check Format parameters and index are valid!");
                pictureBox1.BackgroundImage = ImageStampTool.Properties.Resources.preview1;
            }
        }
        private void showPopUp(string theText)
        {
            labelError.Text = theText;
            panelError.Visible = true;
            timer3s.Start();
        }
        private void radioModified_CheckedChanged(object sender, EventArgs e)
        {
            switch (radioModified.Checked)
            {
                case true:
                    LoadImage();//MessageBox.Show("Radio modified");
                    checkBoxtime.Enabled = true;
                    break;
                case false:
                    checkBoxtime.Enabled = false;
                    break;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            index.Value++;
            LoadImage();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (index.Value > 0)
            {
                index.Value--;
                LoadImage();
            }
            else
            {
                MessageBox.Show("Cannot set value to a negative number.");
            }
        }

        private void radioDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDate.Checked)
            {
                LoadImage();//MessageBox.Show("RadioDate");
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }

        private void radioTextbox_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTextbox.Checked)
            {
                LoadImage(); //MessageBox.Show("Radiotextbox");
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (IsNewProc > 1)
            {
                LoadImage();
            }
            else { IsNewProc++; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadImage(); //MessageBox.Show("Textbox change");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            string digits = "";
            try
            {
                Convert.ToInt32(domainformat.Text);
                digits = Convert.ToInt32(index.Value).ToString("D" + domainformat.Text);
            }
            catch
            {
                digits = index.Value.ToString();
            }
            string FilePth = folderPath.Text + "\\";
            string FileNameNoExtension = textformat1.Text + digits;
            string FileExtension = comboBoxformat.Text;
            
            try
            {
            

                if (pictureBox1.BackgroundImage == null)
                {
                    showPopUp("No image loaded to save.");
                    return;
                }

                string ext = "";
                ImageFormat format = null;

                switch (comboOutput.Text)
                {
                    case "JPEG": ext = ".JPG"; format = ImageFormat.Jpeg; break;
                    case "PNG": ext = ".PNG"; format = ImageFormat.Png; break;
                    case "TIFF": ext = ".TIFF"; format = ImageFormat.Tiff; break;
                    case "BITMAP": ext = ".BMP"; format = ImageFormat.Bmp; break;
                    default:
                        showPopUp("Please select a format.");
                        return;
                }

                string fileName = FileNameNoExtension + "-stamped" + ext;
                string fullPath = Path.Combine(FilePth, fileName);

                pictureBox1.BackgroundImage.Save(fullPath, format);
                showPopUp("Save successful! " + fullPath);
            }
            catch (Exception ex)
            {
                showPopUp("Save failed! " + ex.Message);
            }

        }

        private void domainformat_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateExample();
        }
        private void updateExample()
        {
            string digits = "";
            try
            {
                Convert.ToInt32(domainformat.Text);
                digits = Convert.ToInt32(5).ToString("D" + domainformat.Text);
            }
            catch
            {
                digits = index.Value.ToString();
            }
            labelExample.Text = "Example: " + textformat1.Text + digits + comboBoxformat.Text;
        }

        private void numericUpDownOutlineSize_ValueChanged(object sender, EventArgs e)
        {
            LoadImage(); //MessageBox.Show("size outline change");
        }

        private void comboBoxformat_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateExample();
        }

        private void textformat1_TextChanged(object sender, EventArgs e)
        {
            updateExample();
        }

        private void buttonOutline_BackColorChanged(object sender, EventArgs e)
        {
            LoadImage(); //MessageBox.Show("Outline colour");
        }

        private void buttonMainColour_BackColorChanged(object sender, EventArgs e)
        {
            LoadImage(); //MessageBox.Show("Main colour");
        }

        private void positionBottomRight_Click(object sender, EventArgs e)
        {
            if (IsNewProc > 1)
            {
                LoadImage();
            }
            else { IsNewProc++; }
        }

        private void positionBottomLeft_Click(object sender, EventArgs e)
        {
            LoadImage(); //MessageBox.Show("Bottom left radio");
        }

        private void positionTopRight_Click(object sender, EventArgs e)
        {
            LoadImage(); //MessageBox.Show("top right radio");
        }

        private void positionTopLeft_Click(object sender, EventArgs e)
        {
            LoadImage(); //MessageBox.Show("top left radio");
        }

        private void checkBoxtime_CheckedChanged(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void timer3s_Tick(object sender, EventArgs e)
        {
            panelError.Visible = false;
            timer3s.Stop();
        }

        private void buttonFont_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
