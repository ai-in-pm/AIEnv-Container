using System.Windows;
using System.Windows.Threading;
using Microsoft.Extensions.Logging;

namespace AIEnv.Container.Simple;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly ILogger<MainWindow>? _logger;
    private readonly DispatcherTimer _timer;

    public MainWindow()
    {
        InitializeComponent();
        
        // Initialize timer for status updates
        _timer = new DispatcherTimer();
        _timer.Interval = TimeSpan.FromSeconds(1);
        _timer.Tick += Timer_Tick;
        _timer.Start();

        // Set current user
        UserNameText.Text = Environment.UserName;
        
        // Set initial status
        StatusText.Text = "Ready - AIEnv Integrated Container (Demo Mode)";
    }

    public MainWindow(ILogger<MainWindow> logger) : this()
    {
        _logger = logger;
        _logger?.LogInformation("MainWindow initialized");
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        TimeText.Text = DateTime.Now.ToString("HH:mm:ss");
    }

    private void LaunchAIEnv_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            _logger?.LogInformation("Launching AIEnv interface");
            
            // Hide welcome screen and show AIEnv host
            WelcomeScreen.Visibility = Visibility.Collapsed;
            AIEnvHostBorder.Visibility = Visibility.Visible;
            
            StatusText.Text = "AIEnv interface loaded successfully (Demo Mode)";
            
            MessageBox.Show(
                "AIEnv Interface Demo\n\n" +
                "This demonstrates the AIEnv Integrated Container.\n\n" +
                "Features:\n" +
                "✅ Air-gapped security architecture\n" +
                "✅ Local Windows authentication\n" +
                "✅ BERT AI integration (local processing)\n" +
                "✅ 100% AIEnv functionality preservation\n" +
                "✅ Modern WPF container interface\n\n" +
                "The original AIEnv Windows Forms interface would be\n" +
                "seamlessly embedded here using WindowsFormsHost.",
                "AIEnv Integrated Container",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
        catch (Exception ex)
        {
            _logger?.LogError(ex, "Error launching AIEnv interface");
            StatusText.Text = "Error launching AIEnv interface";
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void ShowChat_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            _logger?.LogInformation("Showing AI chat interface");
            StatusText.Text = "AI Chat interface opened";
            
            MessageBox.Show(
                "AI Chat Interface Demo\n\n" +
                "This demonstrates the local BERT AI chat functionality.\n\n" +
                "Features:\n" +
                "🤖 Local BERT model processing\n" +
                "🔒 100% offline operation (air-gapped)\n" +
                "💬 Development-focused assistance\n" +
                "⚡ Sub-2-second response times\n" +
                "🛡️ No cloud dependencies\n\n" +
                "Model Path: C:\\Users\\djjme\\OneDrive\\Desktop\\AI Shortcuts\\AIEnv\\AIEnv_Container\\AIEnvContainer\\AIEnv Container\\bert-base-uncased-mrpc\n\n" +
                "The AI provides contextual help for:\n" +
                "• Python scripting\n" +
                "• Batch file creation\n" +
                "• PowerShell automation\n" +
                "• AIEnv environment management\n" +
                "• Security best practices",
                "BERT AI Chat",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
        catch (Exception ex)
        {
            _logger?.LogError(ex, "Error showing chat interface");
            StatusText.Text = "Error showing chat interface";
        }
    }

    private void ShowSettings_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            _logger?.LogInformation("Showing settings interface");
            StatusText.Text = "Settings interface opened";
            
            MessageBox.Show(
                "Settings Interface Demo\n\n" +
                "Configuration options include:\n\n" +
                "Security Settings:\n" +
                "• Air-gapped mode enforcement\n" +
                "• Authentication timeout (8 hours)\n" +
                "• Audit logging level\n" +
                "• Network isolation monitoring\n\n" +
                "BERT AI Settings:\n" +
                "• Model path configuration\n" +
                "• Response temperature (0.7)\n" +
                "• Maximum tokens (512)\n" +
                "• Performance optimization\n\n" +
                "UI Settings:\n" +
                "• Theme selection\n" +
                "• Window layout preferences\n" +
                "• Status indicator options",
                "Settings",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
        catch (Exception ex)
        {
            _logger?.LogError(ex, "Error showing settings");
            StatusText.Text = "Error showing settings";
        }
    }

    private void ShowSecurity_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            _logger?.LogInformation("Showing security status");
            StatusText.Text = "Security status displayed";
            
            MessageBox.Show(
                "Security Status Dashboard\n\n" +
                "Current Security Status: ✅ SECURE\n\n" +
                "Air-Gapped Mode: ✅ ACTIVE\n" +
                "• No outbound network connections\n" +
                "• Network activity monitoring enabled\n" +
                "• Firewall rules enforced\n\n" +
                "Authentication: ✅ ACTIVE\n" +
                "• Local Windows authentication\n" +
                "• No cloud dependencies\n" +
                "• Session timeout: 8 hours\n\n" +
                "Data Protection: ✅ ACTIVE\n" +
                "• AES-256-CBC encryption\n" +
                "• PBKDF2 key derivation (100k iterations)\n" +
                "• Secure key management\n\n" +
                "Audit Logging: ✅ ACTIVE\n" +
                "• HIPAA-compliant logging\n" +
                "• Security event tracking\n" +
                "• 30-day retention policy",
                "Security Status",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
        catch (Exception ex)
        {
            _logger?.LogError(ex, "Error showing security status");
            StatusText.Text = "Error showing security status";
        }
    }

    private void ShowAuditLogs_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            _logger?.LogInformation("Showing audit logs");
            StatusText.Text = "Audit logs displayed";
            
            MessageBox.Show(
                "Audit Logs Viewer Demo\n\n" +
                "Recent Security Events:\n\n" +
                $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] APPLICATION_START\n" +
                "Description: AIEnv Integrated Container started\n" +
                "User: " + Environment.UserName + "\n" +
                "Level: Info\n\n" +
                $"[{DateTime.Now.AddMinutes(-5):yyyy-MM-dd HH:mm:ss}] AUTHENTICATION_SUCCESS\n" +
                "Description: Windows user authentication successful\n" +
                "User: " + Environment.UserName + "\n" +
                "Level: Info\n\n" +
                $"[{DateTime.Now.AddMinutes(-10):yyyy-MM-dd HH:mm:ss}] AIRGAP_VALIDATION\n" +
                "Description: Air-gapped mode validation successful\n" +
                "User: System\n" +
                "Level: Info\n\n" +
                "Log Location: %APPDATA%\\AIEnv\\Security\\AuditLogs\\\n" +
                "Retention: 30 days\n" +
                "Format: HIPAA-compliant JSON",
                "Audit Logs",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
        catch (Exception ex)
        {
            _logger?.LogError(ex, "Error showing audit logs");
            StatusText.Text = "Error showing audit logs";
        }
    }

    protected override void OnClosed(EventArgs e)
    {
        _timer?.Stop();
        _logger?.LogInformation("MainWindow closed");
        base.OnClosed(e);
    }
}
