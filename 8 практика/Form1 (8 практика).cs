using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private TextBox textBox;
        private Button btnNew;
        private Button btnOpen;
        private Button btnSave;

        public Form1()
        {
            CreateEditor();
        }

        private void CreateEditor()
        {
           
            this.Text = "Текстовый редактор";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

           
            textBox = new TextBox();
            textBox.Multiline = true;
            textBox.Dock = DockStyle.Fill;
            textBox.ScrollBars = ScrollBars.Both;
            textBox.Font = new System.Drawing.Font("Arial", 11);

            btnNew = new Button();
            btnNew.Text = "Новый";
            btnNew.Size = new System.Drawing.Size(75, 30);
            btnNew.Location = new System.Drawing.Point(10, 10);
            btnNew.Click += BtnNew_Click;

            
            btnOpen = new Button();
            btnOpen.Text = "Открыть";
            btnOpen.Size = new System.Drawing.Size(75, 30);
            btnOpen.Location = new System.Drawing.Point(95, 10);
            btnOpen.Click += BtnOpen_Click;

           
            btnSave = new Button();
            btnSave.Text = "Сохранить";
            btnSave.Size = new System.Drawing.Size(75, 30);
            btnSave.Location = new System.Drawing.Point(180, 10);
            btnSave.Click += BtnSave_Click;

            Panel panel = new Panel();
            panel.Height = 50;
            panel.Dock = DockStyle.Top;
            panel.Controls.Add(btnNew);
            panel.Controls.Add(btnOpen);
            panel.Controls.Add(btnSave);

            
            this.Controls.Add(textBox);
            this.Controls.Add(panel);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            this.Text = "Текстовый редактор - Новый файл";
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        textBox.Text = File.ReadAllText(dialog.FileName);
                        this.Text = "Текстовый редактор - " + Path.GetFileName(dialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка открытия файла: " + ex.Message);
                    }
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(dialog.FileName, textBox.Text);
                        this.Text = "Текстовый редактор - " + Path.GetFileName(dialog.FileName);
                        MessageBox.Show("Файл сохранен!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка сохранения файла: " + ex.Message);
                    }
                }
            }
        }
    }
}