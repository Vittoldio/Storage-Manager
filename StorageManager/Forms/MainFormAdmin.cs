using StorageManager.AccessLevels;

namespace StorageManager
{
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            // ����� ����� ��� ����������� ��� �����/������ + ������ ������� � ������ ����� 
            InitializeComponent();
            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(800, 600);
            button1.Dispose();
        }
    }
}