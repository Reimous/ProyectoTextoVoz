Imports System.Speech.Recognition
Imports System.Threading
Imports System.Globalization
Public Class Form1
    ' recogniser & grammar
    Dim recog As New SpeechRecognizer
    Dim gram As Grammar
    ' events
    Public Event SpeechRecognized As  _
     EventHandler(Of SpeechRecognizedEventArgs)
    Public Event SpeechRecognitionRejected As  _
     EventHandler(Of SpeechRecognitionRejectedEventArgs)
    ' word list
    Dim wordlist As String() = New String() {"Esto", "es", "una", "prueba", "Esto es una prueba"}
    Public RequiredConfidence As Single = 0.7F '0.9F
    ' word recognised event
    Public Sub recevent(ByVal sender As System.Object, _
      ByVal e As RecognitionEventArgs)
        LabelEsto.ForeColor = Color.LightGray
        LabelEs.ForeColor = Color.LightGray
        LabelUna.ForeColor = Color.LightGray
        LabelPrueba.ForeColor = Color.LightGray
        If (e.Result.Text = "Esto") Then
            LabelEsto.ForeColor = Color.Blue
        ElseIf (e.Result.Text = "es") Then
            LabelEs.ForeColor = Color.Blue
        ElseIf (e.Result.Text = "una") Then
            LabelUna.ForeColor = Color.Blue
        ElseIf (e.Result.Text = "prueba") Then
            LabelPrueba.ForeColor = Color.Blue
        ElseIf (e.Result.Text = "Esto es una prueba") Then
            LabelEsto.ForeColor = Color.Green
            LabelEs.ForeColor = Color.Green
            LabelUna.ForeColor = Color.Green
            LabelPrueba.ForeColor = Color.Green
        End If
        'If e.Result.Confidence >= RequiredConfidence Then
        lbl_dicho.Text = e.Result.Text
        hablar()
        'End If


    End Sub
    ' recognition failed event
    Public Sub recfailevent(ByVal sender As System.Object, _
      ByVal e As RecognitionEventArgs)
        LabelEsto.ForeColor = Color.LightGray
        LabelEs.ForeColor = Color.LightGray
        LabelUna.ForeColor = Color.LightGray
        LabelPrueba.ForeColor = Color.LightGray
    End Sub
    ' form initialisation
    Private Sub Form1_Load(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles MyBase.Load
        ' need these to get British English rather than default US
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-ES")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-ES")
        ' convert the word list into a grammar
        Dim words As New Choices(wordlist)
        'gram = New Grammar(New GrammarBuilder(words))
        recog.LoadGrammar(New DictationGrammar)


        ' add handlers for the recognition events
        AddHandler recog.SpeechRecognized, AddressOf Me.recevent
        AddHandler recog.SpeechRecognitionRejected, AddressOf Me.recfailevent
        ' enable the recogniser
        recog.Enabled = True

        'http://stackoverflow.com/questions/17012639/how-can-i-fix-language-for-the-grammar-does-not-match-the-language-of-the-speech
        'http://studentguru.gr/b/jupiter/archive/2010/02/01/speech-recognition-with-c-dictation-and-custom-grammar
        'http://stackoverflow.com/questions/18821566/accuracy-of-ms-system-speech-recognizer-and-the-speechrecognitionengine

        Dim ExtractVoice As New System.Speech.Synthesis.SpeechSynthesizer
        For Each voices In ExtractVoice.GetInstalledVoices
            Me.ComboBox1.Items.Add(voices.VoiceInfo.Name)
        Next
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        hablar()
    End Sub

    Private Sub hablar()
        If ComboBox1.SelectedItem = Nothing Then
            MsgBox("Seleccione un agente")
            ComboBox1.Focus()
        Else
            Try
                Dim Speak As New System.Speech.Synthesis.SpeechSynthesizer
                Speak.SelectVoice(Me.ComboBox1.SelectedItem)
                Speak.SpeakAsync(lbl_dicho.Text)
            Catch ex As Exception
                MsgBox(ex.Message & " Seleccione otra voz")
            End Try
        End If
    End Sub
End Class

