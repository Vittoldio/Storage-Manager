using StorageManager.AccessLevels;

namespace StorageManager
{
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            // Здесь будут все уведомления для юзера/админа + панель доступа в другие формы 
            InitializeComponent();
            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(800, 600);
            button1.Dispose();
        }
    }
}