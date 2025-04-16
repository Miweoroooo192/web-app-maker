Imports System.Windows.Forms
Imports System.IO
Imports System.Net
Imports System.Diagnostics.CodeAnalysis
Imports System.Diagnostics.Metrics
Public Class Form1
    Dim n As String = Environment.NewLine
    Dim folderDialog As New FolderBrowserDialog()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define the command to check Python version
        ' Define the command to check Python version
        Dim processStartInfo As New ProcessStartInfo()
        processStartInfo.FileName = "cmd.exe"
        processStartInfo.Arguments = "/c py --version"
        processStartInfo.RedirectStandardOutput = True
        processStartInfo.UseShellExecute = False
        processStartInfo.CreateNoWindow = True

        Dim process As Process = Process.Start(processStartInfo)
        Dim output As String = process.StandardOutput.ReadToEnd()
        process.WaitForExit()

        ' Display the result in a Label
        If output.Contains("Python") Then
            MessageBox.Show($"Python is installed! Version: {output}", "Python Version Check")
        Else
            MessageBox.Show($"Please install the lastest version of Python.", "Python Version Check")
        End If
    End Sub
    Private Sub RelayBoings_Click(sender As Object, e As EventArgs) Handles RelayBoings.Click

        folderDialog.Description = "Select a folder to save your files"
        folderDialog.ShowNewFolderButton = True

        ' Show the dialog to the user
        If folderDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Retrieve the selected folder path
                Dim folderPath As String = folderDialog.SelectedPath

                ' Example: Specify a file to save within the selected folder
                Dim content As String = "This is the content of your file!"

                ' Write the content to a file in the selected folder
                '

                ' Notify the user of successful operation
                Path.Text = folderPath
            Catch ex As Exception
                ' Handle any errors during the file save
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Notify user that the folder selection was canceled

        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim content = $"import eel{Environment.NewLine}eel.init('web'){Environment.NewLine}eel.start('index.html', port='{port.Text}')"
        Dim temp = IO.Path.GetTempPath()
        Dim folderPath = $"{temp}\{title.Text}"
        Dim filePath = $"{temp}\{title.Text}\app.py"
        If Not String.IsNullOrEmpty(folderDialog.SelectedPath) Then

            folderPath = $"{folderDialog.SelectedPath}"
            filePath = $"{folderDialog.SelectedPath}\app.py"

        Else

        End If

        Dim packageName = "eel" ' Replace this with the package you want to check
        Dim packageName2 = "pyinstaller"
        ' Create a process to run the Python command
        Dim processStartInfo As New ProcessStartInfo
        processStartInfo.FileName = "cmd.exe"
        processStartInfo.Arguments = $"/c py -m pip show {packageName}"
        processStartInfo.RedirectStandardOutput = True
        processStartInfo.UseShellExecute = False
        processStartInfo.CreateNoWindow = True

        Dim process As Process = Process.Start(processStartInfo)
        Dim output = process.StandardOutput.ReadToEnd
        process.WaitForExit()

        If Edge.Checked Then
            content = $"import eel{Environment.NewLine}eel.init('web'){Environment.NewLine}eel.start('index.html', mode='edge', port='{port.Text}')"
        ElseIf Chrome.Checked Then
            content = $"import eel{Environment.NewLine}eel.init('web'){Environment.NewLine}eel.start('index.html', mode='chrome', port='{port.Text}')"
        Else
            MessageBox.Show("Please select a option.", "App Maker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Environment.Exit(0)
        End If


        ' Check if the package is installed
        If output.Contains("Name:") Then
            Dim nope = 69

        ElseIf output.Contains("Name:") Then
            Dim procesStartInfo As New ProcessStartInfo
            procesStartInfo.FileName = "cmd.exe"
            procesStartInfo.Arguments = "/c py -m pip install eel && py -m pip install pyinstaller"
            procesStartInfo.RedirectStandardOutput = False
            procesStartInfo.UseShellExecute = True
            procesStartInfo.CreateNoWindow = False

            Dim proces = Process.Start(processStartInfo)
            Dim outut = process.StandardOutput.ReadToEnd
            process.WaitForExit()
            MessageBox.Show($"The packages 'eel' and 'pyinstaller' are installed!", "Python Package Check", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Try
            ' Create the directory if it doesn't exist
            Dim directoryPath = IO.Path.GetDirectoryName(filePath)
            If Not IO.Directory.Exists(directoryPath) Then
                IO.Directory.CreateDirectory(directoryPath)
            End If
            Dim directoryPath2 = $"{folderPath}\web"
            If Not IO.Directory.Exists(directoryPath2) Then

                IO.Directory.CreateDirectory(directoryPath2)
                MessageBox.Show("File created successfully with the provided content!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If Not File.Exists($"{folderPath}\web\index.html") Then
                Dim contet = $"<!DOCTYPE html><html><head><title>{title.Text}</title>

  </head>
  <body>
    <script src='trollbox.js'></script>
    <h1>Restart the App of it doenst automatically redirect to {title.Text}</h1>
  </body>
</html>"

                Dim htmlfilePath = $"{folderPath}\web\index.html"
                File.WriteAllText(htmlfilePath, contet)
                MessageBox.Show("File created successfully with the provided content!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If Not File.Exists($"{folderPath}\web\trollbox.js") Then
                Dim contete = $"location.href = '{website.Text}';"
                Dim JSfilePath = $"{folderPath}\web\trollbox.js"
                File.WriteAllText(JSfilePath, contete)
                MessageBox.Show("File created successfully with the provided content!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            ' Write the content to the file
            File.WriteAllText(filePath, content)
            MessageBox.Show("File created successfully with the provided content!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Try
                Dim procestartInfo As New ProcessStartInfo
                procestartInfo.FileName = "cmd.exe"
                procestartInfo.Arguments = $"/c cd {folderPath} && py -m eel app.py web --onefile --noconsole"
                procestartInfo.RedirectStandardOutput = False
                procestartInfo.UseShellExecute = True
                procestartInfo.CreateNoWindow = False
                Dim dimdimdim = process.Start(procestartInfo)

                MessageBox.Show($"The application was successfully packaged and executed! (Folder Source: {folderPath} )", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            ' Handle any errors (e.g., permission issues)
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
