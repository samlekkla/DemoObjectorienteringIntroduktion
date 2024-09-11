using DemoObjectorienteringIntroduktion.Class;

namespace DemoObjectorienteringIntroduktion
{
    public partial class FormCreateUser : Form
    {
        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Vi skapaar upp en instans av klassen User.
            //New används för detta. Här skickar vi inga värde till komnstruktorn
            User user = new User();
            user.Username = textBoxUsername.Text;
            user.Password = textBoxPassword.Text;
            user.Email = textBoxEmail.Text;

            //Detta andra alternativet är att skickar in värden via
            //konstruktorn. Använd oftast

            User user2 = new User(textBoxUsername.Text,
                textBoxPassword.Text, textBoxEmail.Text);

            //Efter värden är satta sparas dessa
            user2.Save();

        }
    }
}
