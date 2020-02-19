using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISYS3393Homework3
{
    static class FlowerShopControls
    {
        static FlowerShop flowerShop;
        static Flowers[] flowers;
        static int numOfOccasions = 6;

        static bool photoEnabled = false;

        static string[] occasionCollection;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            flowerShop = new FlowerShop();
            InitVariables();
            Application.Run(flowerShop);
        }

        static void InitVariables()
        {
            flowers = new Flowers[5];
            occasionCollection = new String[20];                    // Creating a string array of size 20
            for(int i = 0; i < occasionCollection.Length; i++)
            {
                occasionCollection[i] = "";
            }
            occasionCollection[0] = "Anniversary";
            occasionCollection[1] = "Birthday";
            occasionCollection[2] = "I'm Sorry";
            occasionCollection[3] = "Just Because";
            occasionCollection[4] = "Love & Romance";
            occasionCollection[5] = "Thank You";

            flowers[0] = new Flowers("Roses",global::ISYS3393Homework3.Properties.Resources.Roses);
            flowers[1] = new Flowers("Orchids", global::ISYS3393Homework3.Properties.Resources.Orchids);
            flowers[2] = new Flowers("Lilies", global::ISYS3393Homework3.Properties.Resources.Lilies);
            flowers[3] = new Flowers("Daisies", global::ISYS3393Homework3.Properties.Resources.Daisies);
            flowers[4] = new Flowers("Tulips", global::ISYS3393Homework3.Properties.Resources.Tulip);


            flowerShop.SetOccasions(occasionCollection);
        }

        static void CreatePopup(string caption, string message)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        public static void Clear()
        {
            System.Drawing.Image image = null;
            System.Windows.Forms.GroupBox tempGroupBox = flowerShop.GetGroupBox();
            foreach (RadioButton r in tempGroupBox.Controls.OfType<RadioButton>())      // Unchecks all RadioButtons
            {
                r.Checked = false;
            }
            flowerShop.SetPhotoBoxVisible(false);                                       // Makes the photobox invisible
            flowerShop.SetPhoto(image);                                                 // Clears the image
            flowerShop.SetChecked(false);                                               // Unchecks the checkbox
            flowerShop.ClearTextBox();                                                  // Clears the TextBox
            flowerShop.ClearSelection();                                                // Clears selected item from the list
        }

        public static void Total()
        {
            string caption = "Occasion Total";
            // Create Windows screen that prints the total number of Occasions
            string print = String.Format("There are {0} occasions", numOfOccasions);
            CreatePopup(caption, print);
        }

        public static void Exit()
        {
            Application.Exit();
        }

        public static void Add()
        {
            string textBoxString = flowerShop.GetTextBox();             // Get the textBox text from the form
            if(!textBoxString.Equals(""))                               // if the text recieved is not empty
            {
                if (!occasionCollection.Contains(textBoxString))        // If the text recieved is not in the occasion array
                { 
                    occasionCollection[numOfOccasions] = textBoxString;         // the numOfOccasions int will point to the next value in the array, as the array starts at 0, while we count from 1. Add the added value to the next array slot
                    numOfOccasions++;                                           // increment our counter
                    flowerShop.SetOccasions(occasionCollection);                // Update the list
                }
                else
                {
                    CreatePopup("Already Exists", String.Format("The Entry {0} is already on the list of occasions", textBoxString));   // Value exists in the listBox error
                }
            }
            else
            {
                CreatePopup("Entry is Blank", "You cannot add a blank entry into the list of occasions");               // Added value is blank error
            }
        }

        public static void Delete()
        {
             
            string selectedItem = flowerShop.GetListSelectedItem();                             // Setting a string equal to the currently selected item in the list
            if (selectedItem.Equals("-1"))                                                      // Error handling, If we return a -1, this is an error
            {
                CreatePopup("Nothing Selected", "There is nothing selected for deletion");      // create a popup 
            }
            else
            {
                for (int i = 0; i < occasionCollection.Length; i++)                             // for loop
                {
                    if (occasionCollection[i].Equals(selectedItem))                             // If our occasion in array position i is equal to the selected item
                    {
                        //occasionCollection[i] = "";
                        for (int j = i; j < occasionCollection.Length - 1; j++)                // Shift the array down
                        {
                            occasionCollection[j] = occasionCollection[j + 1];                  // Set the current array value equal to the next array value (moving everything down so we dont have holes in the array)
                        }
                        numOfOccasions--;                                                       // Decreasing the number of things in the occasions array
                        flowerShop.SetOccasions(occasionCollection);                            // Setting the listBox to the occasion Array
                    }
                }
            }

        }

        public static void PhotoCheck()
        {
            System.Windows.Forms.GroupBox tempGroupBox = flowerShop.GetGroupBox();          // Get the groupbo from the flowerShop object
            foreach (RadioButton r in tempGroupBox.Controls.OfType<RadioButton>())          // for all radio buttons in the groupbox
            {
                if (r.Checked)                                                              // if they are checked (only one can be)
                {
                    for (int i = 0; i < flowers.Length; i++)                                // for loop
                    {
                        if (r.Text.Equals(flowers[i].Name))                                 // If the radio button text is equal to the flower at the current I value in the array
                        {
                            flowerShop.SetPhoto(flowers[i].Image);                          // Set the pictureBox equal to the image value found in the flowers object
                        }
                    }
                }
            }
        }

        public static void EnablePhoto()                                                    // Simple flip flop.
        { 
            if (photoEnabled)                                                               // If the photo is currently enabled,
            {
                flowerShop.SetPhotoBoxVisible(false);                                       // make the photo invisible
                photoEnabled = false;
            }
            else                                                                            // Else
            {
                flowerShop.SetPhotoBoxVisible(true);                                        // make the photo visible/
                photoEnabled = true;
            }
                
        }
    }
}
