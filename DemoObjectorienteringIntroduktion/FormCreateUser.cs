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
            //New anv�nds f�r detta. H�r skickar vi inga v�rde till komnstruktorn
            User user = new User();
            user.Username = textBoxUsername.Text;
            user.Password = textBoxPassword.Text;
            user.Email = textBoxEmail.Text;

            //Detta andra alternativet �r att skickar in v�rden via
            //konstruktorn. Anv�nd oftast

            User user2 = new User(textBoxUsername.Text,
                textBoxPassword.Text, textBoxEmail.Text);

            //Efter v�rden �r satta sparas dessa
            user2.Save();

        }
    }
}
