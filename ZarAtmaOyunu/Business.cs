using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtmaOyunu
{
    public class Business
    {

        public bool IsNumeric(string text)
        {
            bool result = true;
            foreach (char item in text)
            {
                if (!Char.IsNumber(item))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        public bool WinnerControl(int score, Player player,int finishScore)
        {
            bool value = false;
            if (score >= finishScore)
            {
                DialogResult dialogResult = MessageBox.Show("Tebrikler " + player.PlayerId.ToString() + ". Oyuncu Kazandı", "Tebrikler", MessageBoxButtons.RetryCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    Form.ActiveForm.Close();
                    return value;
                }
                else
                {
                    value = true;
                    return value;
                }
            }
            return value;
        }
        public Bitmap GetResourceImages(int rnd)
        {
            IEnumerable<PropertyInfo> props = typeof(Properties.Resources).GetProperties(BindingFlags.NonPublic | BindingFlags.Static).Where(prop => prop.PropertyType == typeof(Bitmap));
            var images = props.Select(prop => prop.GetValue(null, null) as Bitmap).ToArray();
            return images[rnd];
        }
        public int GetResourceImagesLength()
        {
            IEnumerable<PropertyInfo> props = typeof(Properties.Resources).GetProperties(BindingFlags.NonPublic | BindingFlags.Static).Where(prop => prop.PropertyType == typeof(Bitmap));
            var images = props.Select(prop => prop.GetValue(null, null) as Bitmap).ToArray();
            return images.Length;
        }
        public int GetResourceImageValue(int rnd)
        {
            IEnumerable<PropertyInfo> props = typeof(Properties.Resources).GetProperties(BindingFlags.NonPublic | BindingFlags.Static).Where(prop => prop.PropertyType == typeof(Bitmap));
            var imagesName = props.Select(prop => prop.Name).ToArray();
            var value = Convert.ToInt32(imagesName[rnd].Remove(0, 1));
            return value;
        }

    }
}
