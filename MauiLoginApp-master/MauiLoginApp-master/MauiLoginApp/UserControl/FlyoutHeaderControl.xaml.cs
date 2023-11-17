namespace MauiLoginApp.UserControl;

public partial class FlyoutHeaderControl : ContentPage
{
	public FlyoutHeaderControl()
	{

		InitializeComponent();

		if (App.CurrentUser != null)
		{
			lblUserName.Text = $"�� ����� ���: Admin";
            lblUserRole.Text = "admin@admin.kg";
		}
		else
		{
            lblUserName.Text = $"�� ����� ���: �����";
            lblUserRole.Text = "Admin";
        }
	}
}