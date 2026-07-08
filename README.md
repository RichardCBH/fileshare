# FileShare - IPv6 HTTP 文件共享 Android App

使用 **.NET 8** 和 **.NET MAUI** 开发的 Android APK 应用。

## 功能目标

- 选择手机上的任意文件夹进行“挂载”
- 指定端口（默认 8080）
- 使用 **IPv6** 地址启动 HTTP 文件共享服务器
- 其他手机/设备通过浏览器访问 `http://[ipv6地址]:端口/` 即可浏览和下载文件夹内的文件
- 使用 **GitHub Actions** 自动编译生成 APK

## 当前状态

仓库已初始化，包含 GitHub Actions 构建流程和基本 .NET MAUI 项目骨架。

完整功能实现中（涉及 Android Foreground Service、Storage Access Framework、嵌入式 HTTP 服务器等高级功能）。

## 本地构建方法

1. 安装 .NET 8 SDK 和 MAUI workload：
   ```bash
   dotnet workload install maui
   ```
2. 创建或使用当前项目
3. 构建 APK：
   ```bash
   dotnet publish -f net8.0-android -c Release
   ```

## GitHub Actions

推送代码后，Actions 会自动构建 Debug APK 并上传为 artifact。

## 技术栈

- .NET 8 / .NET MAUI
- C#
- HttpListener 或轻量级 Web Server
- Android Foreground Service
- Storage Access Framework (SAF)

## 路线图 (Roadmap)

- [x] 项目骨架 + CI/CD
- [ ] UI 界面（端口输入、选择文件夹、启动/停止、显示 URL）
- [ ] 获取设备 IPv6 地址
- [ ] 实现简单 HTTP 文件服务器（目录列表 + 下载）
- [ ] Android Foreground Service 保持后台运行
- [ ] 集成 SAF 文件夹选择和持久权限
- [ ] 支持 IPv6 绑定
- [ ] 测试多设备访问

欢迎告诉我下一步想先实现哪部分！
