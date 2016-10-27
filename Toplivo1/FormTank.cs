using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Toplivo
{
    public partial class FormTank : Form
    {
        private string strPictureDir="/TankPictures/";
        public FormTank()
        {
            InitializeComponent();
        }

        private void tanksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            tanksBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(toplivo_DataSet);

        }

        private void FormTank_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Tanks". При необходимости она может быть перемещена или удалена.
            tanksTableAdapter.Fill(toplivo_DataSet.Tanks);
            string strPicturePath = tankPictureTextBox.Text.ToString();
            //Считывание изображения из каталога strPictureDir и отображение его на форме
            strPicturePath = Directory.GetCurrentDirectory() + strPicturePath;
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
            string strPicturePath = strPictureDir + tankIDTextBox.Text.ToString() + ".jpg";
            string strPictureFullPath = Directory.GetCurrentDirectory() + strPicturePath;

            //Выбор файла для изображения
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "файлы изображений (*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            string strFileName = openFileDialog1.FileName ;
            if (strFileName!="")
            {
            //Копирование в нужный каталог
            try
                {
                    File.Copy(strFileName, strPictureFullPath, true);

                    //Запись пути к файлу в соответсвующую таблицу базы данных
                    tankPictureTextBox.Text = strPicturePath;
                    tanksBindingSource.EndEdit();
                    tanksTableAdapter.Update(toplivo_DataSet.Tanks);

                    //Отображение в элементе PictureBox
                    if (File.Exists(strPictureFullPath)) TankPictureBox.Image = Image.FromFile(strPictureFullPath);

                }

            // Обработка ошибки копирования
            catch (IOException copyError)
                {
                    System.Windows.Forms.MessageBox.Show(copyError.Message);
                
                }
            
            }
            
 
        }

        
    }
}
