using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toplivo1
{
    public partial class FormTank : Form
    {

        private string strPictureDir="\\TankPictures\\";
        public FormTank()
        {
            InitializeComponent();
        }

        private void tanksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tanksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.toplivo_DataSet);

        }

        private void FormTank_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Tanks". При необходимости она может быть перемещена или удалена.
            this.tanksTableAdapter.Fill(this.toplivo_DataSet.Tanks);
            string strPicturePath = tankPictureTextBox.Text.ToString();
            //Считывание изображения из каталога strPictureDir и отображение его на форме
            strPicturePath = Directory.GetCurrentDirectory() + strPictureDir + strPicturePath;
            if (File.Exists(strPicturePath))
            {
                TankPictureBox.Image = Image.FromFile(strPicturePath);

            }
            
        }

        private void FormTank_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void UploadPictureButton_Click(object sender, EventArgs e)
        {
            //Выбор файла
            string strPicturePath = strPictureDir + tankIDTextBox.Text.ToString() + ".jpg";
            string strPictureFullPath = Directory.GetCurrentDirectory() + strPicturePath;


            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "файлы изображений (*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            string strFileName = openFileDialog1.FileName ;
            if (strFileName!="")
            {
            //Копирование в нужный каталог
            try
                {
                    File.Copy(strFileName, strPictureFullPath, true);
                }

            // Catch exception if the file was already copied.
            catch (IOException copyError)
                {
                    Console.WriteLine(copyError.Message);
                }
            
            
            
            
            
            }
            
            //Запись пути к файлу в соответсвующую таблицу базы данных
            tankPictureTextBox.Text = tankIDTextBox.Text.ToString() + ".jpg";
            tanksBindingSource.EndEdit();
            //tanksTableAdapter.Update(toplivo_DataSet);
            //Отображение в элементе PictureBox
            if (File.Exists(strPictureFullPath))
                TankPictureBox.Image = Image.FromFile(strPictureFullPath);

        }

        
    }
}
