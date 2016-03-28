using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;



namespace WebCalculator
{
    public partial class Calculation : System.Web.UI.Page
    {

        protected void OnBuildSimpleCalc(object sender, EventArgs e)
        {

            if (addCheckBox.Checked)
            {
                addOp1.Visible = true;
                addOp2.Visible = true;
                addButton.Visible = true;
            }

            if (subCheckBox.Checked)
            {
                subOp1.Visible = true;
                subOp2.Visible = true;
                subButton.Visible = true;
            }

            if (divCheckBox.Checked)
            {
                divOp1.Visible = true;
                divOp2.Visible = true;
                divButton.Visible = true;
            }

            if (mulCheckBox.Checked)
            {
                mulOp1.Visible = true;
                mulOp2.Visible = true;
                mulButton.Visible = true;
            }
            if (ComAddCheckBox.Checked)
            {
                ComAdd1.Visible = true;
                ComAdd2.Visible = true;
                ComAdd3.Visible = true;
                ComAdd4.Visible = true;
                addNum1Label.Visible = true;
                addNum2Label.Visible = true;
                ComplexAddButton.Visible = true;
            }
            if (ComSubCheckBox.Checked)
            {
                ComSub1.Visible = true;
                ComSub2.Visible = true;
                ComSub3.Visible = true;
                ComSub4.Visible = true;
                subNum1Label.Visible = true;
                subNum2Label.Visible = true;
                ComplexSubButton.Visible = true;
            }
            if (ComDivCheckBox.Checked)
            {
                ComDiv1.Visible = true;
                ComDiv2.Visible = true;
                ComDiv3.Visible = true;
                ComDiv4.Visible = true;
                divNum1Label.Visible = true;
                divNum2Label.Visible = true;
                ComplexDivButton.Visible = true;
            }
            if (ComMulCheckBox.Checked)
            {
                ComMul1.Visible = true;
                ComMul2.Visible = true;
                ComMul3.Visible = true;
                ComMul4.Visible = true;
                mulNum1Label.Visible = true;
                mulNum2Label.Visible = true;
                ComplexMulButton.Visible = true;
            }

            if (ComAddCheckBox.Checked || ComSubCheckBox.Checked || ComMulCheckBox.Checked || ComDivCheckBox.Checked)
            {
                realLabel.Visible = true;
                imaginaryLabel.Visible = true;
            }
            

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.LoadFrom("C:\\Users\\Eason Lee\\Documents\\Visual Studio 2013\\Projects\\WebCalculator\\A2cal\\A2cal\\bin\\Debug\\A2cal.dll");
            Type myType = assembly.GetType("EasonLee.SimpleCal");
            MethodInfo Method = myType.GetMethod("Add");
            object myInstance = Activator.CreateInstance(myType);
            double num1 = Convert.ToDouble(addOp1.Text);
            double num2 = Convert.ToDouble(addOp2.Text);
            addResult.Text = "" + Method.Invoke(myInstance, new object[] { num1, num2 });
            addResult.Visible = true;
        }

        protected void subButton_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.LoadFrom("C:\\Users\\Eason Lee\\Documents\\Visual Studio 2013\\Projects\\WebCalculator\\A2cal\\A2cal\\bin\\Debug\\A2cal.dll");
            Type myType = assembly.GetType("EasonLee.SimpleCal");
            MethodInfo Method = myType.GetMethod("Subtraction");
            object myInstance = Activator.CreateInstance(myType);
            double num1 = Convert.ToDouble(subOp1.Text);
            double num2 = Convert.ToDouble(subOp2.Text);
            subResult.Text = "" + Method.Invoke(myInstance, new object[] { num1, num2 });
            subResult.Visible = true;
        }

        protected void divButton_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.LoadFrom("C:\\Users\\Eason Lee\\Documents\\Visual Studio 2013\\Projects\\WebCalculator\\A2cal\\A2cal\\bin\\Debug\\A2cal.dll");
            Type myType = assembly.GetType("EasonLee.SimpleCal");
            MethodInfo Method = myType.GetMethod("Division");
            object myInstance = Activator.CreateInstance(myType);
            double num1 = Convert.ToDouble(divOp1.Text);
            double num2 = Convert.ToDouble(divOp2.Text);
            divResult.Text = "" + Method.Invoke(myInstance, new object[] { num1, num2 });
            divResult.Visible = true;
        }

        protected void mulButton_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.LoadFrom("C:\\Users\\Eason Lee\\Documents\\Visual Studio 2013\\Projects\\WebCalculator\\A2cal\\A2cal\\bin\\Debug\\A2cal.dll");
            Type myType = assembly.GetType("EasonLee.SimpleCal");
            MethodInfo Method = myType.GetMethod("Multiplication");
            object myInstance = Activator.CreateInstance(myType);
            double num1 = Convert.ToDouble(mulOp1.Text);
            double num2 = Convert.ToDouble(mulOp2.Text);
            mulResult.Text = "" + Method.Invoke(myInstance, new object[] { num1, num2 });
            mulResult.Visible = true;
            //Console.WriteLine();
            
        }

        protected void ComplexAdd_Click(object sender, EventArgs e)
        {
           // Console.WriteLine(new System.IO.StreamReader("C:\Users\Eason Lee\Documents\Visual Studio 2013\Projects\Gui-based Cal\A2cal\A2cal\bin\\A2cal.dll"));

            Assembly assembly = Assembly.LoadFrom("C:\\Users\\Eason Lee\\Documents\\Visual Studio 2013\\Projects\\WebCalculator\\A2cal\\A2cal\\bin\\Debug\\A2cal.dll");
            Type myType = assembly.GetType("EasonLee.ComplexCal");
            MethodInfo Method = myType.GetMethod("Add");
            object myInstance = Activator.CreateInstance(myType);
     
            Type myType1 = assembly.GetType("A2cal.ComplexNumber");
            object myInstance1 = Activator.CreateInstance(myType1, (float)Convert.ToDouble(ComAdd1.Text),(float)Convert.ToDouble(ComAdd2.Text));
            object myInstance2 = Activator.CreateInstance(myType1, (float)Convert.ToDouble(ComAdd3.Text), (float)Convert.ToDouble(ComAdd4.Text));
            object result1 = Method.Invoke(myInstance, new object[] { myInstance1, myInstance2 });


            ComplexAdd1.Text = "" + result1.GetType().GetProperty("real").GetValue(result1, null);
            ComplexAdd1.Visible = true;
            ComplexAdd2.Text = "" + result1.GetType().GetProperty("imaginary").GetValue(result1, null);
            ComplexAdd2.Visible = true;

            
     

        }

        protected void ComplexSub_Click(object sender, EventArgs e)
        {
            /*Assembly assembly = Assembly.LoadFrom("C:/Users/Eason Lee/Documents/Visual Studio 2013/Projects/WebCalculator/WebCalculator/A2cal/A2cal/bin/Debug/A2cal.dll");
            Assembly assembly = Assembly.LoadFrom("A2cal.dll");
            Type myType = assembly.GetType("EaonLee.ComplexCal");
            MethodInfo Method = myType.GetMethod("Subtraction");
            object myInstance = Activator.CreateInstance(myType);
            double num1 = Convert.ToDouble(ComSub1.Text);
            double num2 = Convert.ToDouble(ComSub1.Text);
            addResult.Text = "" + Method.Invoke(myInstance, new object[] { num1, num2 });
            addResult.Visible = true;*/

            Assembly assembly = Assembly.LoadFrom("C:\\Users\\Eason Lee\\Documents\\Visual Studio 2013\\Projects\\WebCalculator\\A2cal\\A2cal\\bin\\Debug\\A2cal.dll");
            Type myType = assembly.GetType("EasonLee.ComplexCal");
            MethodInfo Method = myType.GetMethod("Subtraction");
            object myInstance = Activator.CreateInstance(myType);

            Type myType1 = assembly.GetType("A2cal.ComplexNumber");
            object myInstance1 = Activator.CreateInstance(myType1, (float)Convert.ToDouble(ComSub1.Text), (float)Convert.ToDouble(ComSub2.Text));
            object myInstance2 = Activator.CreateInstance(myType1, (float)Convert.ToDouble(ComSub3.Text), (float)Convert.ToDouble(ComSub4.Text));
            object result1 = Method.Invoke(myInstance, new object[] { myInstance1, myInstance2 });


            ComplexSub1.Text = "" + result1.GetType().GetProperty("real").GetValue(result1, null);
            ComplexSub1.Visible = true;
            ComplexSub2.Text = "" + result1.GetType().GetProperty("imaginary").GetValue(result1, null);
            ComplexSub2.Visible = true;

        }

        protected void ComplexDiv_Click(object sender, EventArgs e)
        {
            /*Assembly assembly = Assembly.LoadFrom("C:/Users/Eason Lee/Documents/Visual Studio 2013/Projects/WebCalculator/WebCalculator/A2cal/A2cal/bin/Debug/A2cal.dll");
            Type myType = assembly.GetType("EaonLee.ComplexCal");
            MethodInfo Method = myType.GetMethod("Division");
            object myInstance = Activator.CreateInstance(myType);
            double num1 = Convert.ToDouble(ComDiv1.Text);
            double num2 = Convert.ToDouble(ComDiv2.Text);
            addResult.Text = "" + Method.Invoke(myInstance, new object[] { num1, num2 });
            addResult.Visible = true;*/

            Assembly assembly = Assembly.LoadFrom("C:\\Users\\Eason Lee\\Documents\\Visual Studio 2013\\Projects\\WebCalculator\\A2cal\\A2cal\\bin\\Debug\\A2cal.dll");
            Type myType = assembly.GetType("EasonLee.ComplexCal");
            MethodInfo Method = myType.GetMethod("Division");
            object myInstance = Activator.CreateInstance(myType);

            Type myType1 = assembly.GetType("A2cal.ComplexNumber");
            object myInstance1 = Activator.CreateInstance(myType1, (float)Convert.ToDouble(ComDiv1.Text), (float)Convert.ToDouble(ComDiv2.Text));
            object myInstance2 = Activator.CreateInstance(myType1, (float)Convert.ToDouble(ComDiv3.Text), (float)Convert.ToDouble(ComDiv4.Text));
            object result1 = Method.Invoke(myInstance, new object[] { myInstance1, myInstance2 });


            ComplexDiv1.Text = "" + result1.GetType().GetProperty("real").GetValue(result1, null);
            ComplexDiv1.Visible = true;
            ComplexDiv2.Text = "" + result1.GetType().GetProperty("imaginary").GetValue(result1, null);
            ComplexDiv2.Visible = true;

        }

        protected void CompexMul_Click(object sender, EventArgs e)
        {
            /*Assembly assembly = Assembly.LoadFrom("C:/Users/Eason Lee/Documents/Visual Studio 2013/Projects/WebCalculator/WebCalculator/A2cal/A2cal/bin/Debug/A2cal.dll");
            Type myType = assembly.GetType("EaonLee.ComplexCal");
            MethodInfo Method = myType.GetMethod("Multiplication");
            object myInstance = Activator.CreateInstance(myType);
            double num1 = Convert.ToDouble(ComMul1.Text);
            double num2 = Convert.ToDouble(ComMul2.Text);
            addResult.Text = "" + Method.Invoke(myInstance, new object[] { num1, num2 });
            addResult.Visible = true;*/

            Assembly assembly = Assembly.LoadFrom("C:\\Users\\Eason Lee\\Documents\\Visual Studio 2013\\Projects\\WebCalculator\\A2cal\\A2cal\\bin\\Debug\\A2cal.dll");
            Type myType = assembly.GetType("EasonLee.ComplexCal");
            MethodInfo Method = myType.GetMethod("Multiplication");
            object myInstance = Activator.CreateInstance(myType);

            Type myType1 = assembly.GetType("A2cal.ComplexNumber");
            object myInstance1 = Activator.CreateInstance(myType1, (float)Convert.ToDouble(ComMul1.Text), (float)Convert.ToDouble(ComMul2.Text));
            object myInstance2 = Activator.CreateInstance(myType1, (float)Convert.ToDouble(ComMul3.Text), (float)Convert.ToDouble(ComMul4.Text));
            object result1 = Method.Invoke(myInstance, new object[] { myInstance1, myInstance2 });

            ComplexMul1.Text = "" + result1.GetType().GetProperty("real").GetValue(result1, null);
            ComplexMul1.Visible = true;
            ComplexMul2.Text = "" + result1.GetType().GetProperty("imaginary").GetValue(result1, null);
            ComplexMul2.Visible = true;
        }
        
    }

}
