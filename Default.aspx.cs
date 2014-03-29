using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void b_submit_Click(object sender, EventArgs e)
    {
        // create a writer and open the file
            TextWriter tw = new StreamWriter("D:\\code.java");
        // write a line of text to the file
            tw.WriteLine(tb_code.Text);
        // close the stream
            tw.Close();
            CommandLine cl = new CommandLine();
           string output = cl.call_cmd("javac code.java");
        
           output = cl.call_cmd("java code");
       // String output = cl.call_cmd(tb_code.Text);
            tb_code.Text = output;
    }

    protected void b_clear_Click(object sender, EventArgs e)
    {
        tb_code.Text = null;
    }
}

public partial class CommandLine : System.Web.UI.Page
{
    public String call_cmd(String cmd)
    {
        System.Diagnostics.Process si = new System.Diagnostics.Process();
        si.StartInfo.WorkingDirectory = "d:\\";
        si.StartInfo.UseShellExecute = false;
        si.StartInfo.FileName = "cmd.exe";
        si.StartInfo.Arguments = "/c "+cmd;
        si.StartInfo.CreateNoWindow = true;
        si.StartInfo.RedirectStandardInput = true;
        si.StartInfo.RedirectStandardOutput = true;
        si.StartInfo.RedirectStandardError = true;
        si.Start();
        string output = si.StandardOutput.ReadToEnd();
        si.Close();
        return output;
    }
}