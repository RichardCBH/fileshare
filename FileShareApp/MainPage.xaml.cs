using Microsoft.Maui.Controls;

namespace FileShareApp;

public partial class MainPage : ContentPage
{
	private string? _selectedFolderPath;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnPickFolderClicked(object sender, EventArgs e)
	{
		// TODO: 实现 Android SAF 文件夹选择
		// 目前使用简单提示
		await DisplayAlert("提示", "这里将集成 Android Storage Access Framework 来选择任意文件夹", "OK");
		// 暂时模拟
		_selectedFolderPath = "/storage/emulated/0/Download"; // 示例
		FolderLabel.Text = $"已选择: {_selectedFolderPath}";
		FolderLabel.TextColor = Colors.Green;
	}

	private async void OnStartServerClicked(object sender, EventArgs e)
	{
		if (!int.TryParse(PortEntry.Text, out int port) || port < 1 || port > 65535)
		{
			await DisplayAlert("错误", "请输入有效端口号 (1-65535)", "OK");
			return;
		}

		// TODO: 真正启动 HttpListener + Foreground Service + IPv6
		string ipv6 = "[::]"; // 暂时硬编码
		string url = $"http://{ipv6}:{port}/";

		StatusLabel.Text = $"服务器已启动 (Debug 模式)";
		StatusLabel.TextColor = Colors.Green;
		UrlLabel.Text = $"访问地址: {url}\n\n正在开发中... 完整版本将支持真正文件共享";

		await DisplayAlert("开始", $"假如服务器已在 {url} 运行\n\n下一步将实现真正的文件列表和下载功能。", "OK");
	}
}
