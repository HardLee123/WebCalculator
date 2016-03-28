<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculation.aspx.cs" Inherits="WebCalculator.Calculation" %>

<!DOCTYPE html>
<html> 
    <head>
    <title>WebCalcution</title>
        <style type="text/css">
            .auto-style1 {
                width: 68px;
            }
        </style>
    </head>
    <h1><center>Web Calculation</center></h1>
    <h2>Simple Calc</h2>
  <body>
    <form runat="server">
   
           <table>
               <tr>
                    <td>
                            <asp:CheckBox ID="addCheckBox" RunAt="server" />
                    </td>
                   <td>
                       Add
                   </td>
                   <td>
                       <asp:TextBox ID="addOp1" RunAt="server" Visible="false" />
                   </td>
                   <td>
                       <asp:TextBox ID="addOp2" RunAt="server"  Visible="false"/>
                   </td>
                   <td>
                       <asp:Button Text="  =  " RunAt="server" Visible="false" ID="addButton" OnClick="addButton_Click" />
                   </td>
                   <td>
                       <asp:Label ID="addResult" RunAt="server"  Visible="false"/>
                   </td>
               </tr>

               <tr>
                    <td>
                            <asp:CheckBox ID="subCheckBox" RunAt="server" />
                    </td>
                   <td>
                       Subtract
                   </td>
                   <td>
                       <asp:TextBox ID="subOp1" RunAt="server" Visible="false" />
                   </td>
                   <td>
                       <asp:TextBox ID="subOp2" RunAt="server"  Visible="false"/>
                   </td>
                   <td>
                       <asp:Button Text="  =  " RunAt="server" Visible="false" ID="subButton" OnClick="subButton_Click" />
                   </td>
                   <td>
                       <asp:Label ID="subResult" RunAt="server"  Visible="false"/>
                   </td>
               </tr>

               <tr>
                    <td>
                            <asp:CheckBox ID="divCheckBox" RunAt="server" />
                    </td>
                   <td>
                       Divide
                   </td>
                   <td>
                       <asp:TextBox ID="divOp1" RunAt="server" Visible="false" />
                   </td>
                   <td>
                       <asp:TextBox ID="divOp2" RunAt="server"  Visible="false"/>
                   </td>
                   <td>
                       <asp:Button Text="  =  " RunAt="server" Visible="false" ID="divButton" OnClick="divButton_Click" />
                   </td>
                   <td>
                       <asp:Label ID="divResult" RunAt="server"  Visible="false"/>
                   </td>
               </tr>

               <tr>
                    <td>
                             <asp:CheckBox ID="mulCheckBox" RunAt="server" />
                    </td>
                   <td>
                       Multiply
                   </td>
                   <td>
                       <asp:TextBox ID="mulOp1" RunAt="server" Visible="false" />
                   </td>
                   <td>
                       <asp:TextBox ID="mulOp2" RunAt="server"  Visible="false"/>
                   </td>
                   <td>
                       <asp:Button Text="  =  " RunAt="server" Visible="false" ID="mulButton" OnClick="mulButton_Click" />
                   </td>
                   <td>
                       <asp:Label ID="mulResult" RunAt="server"  Visible="false"/>
                   </td>
               </tr>
           </table>

        <h2>Complex Calc</h2>
           <table>
               <tr>
                   <td>
                            
                   </td>
                   <td class="auto-style1">               
                   </td>
                   <td style="text-align: center;">
                        <asp:Label ID="realLabel" RunAt="server"  Visible="false" Text="Real"/>
                   </td>
                   <td style="text-align: center;">
                       <asp:Label ID="imaginaryLabel" RunAt="server"  Visible="false" Text="Imaginary"/>
                   </td>
               </tr>

               <tr>
                    <td>
                            <asp:CheckBox ID="ComAddCheckBox" RunAt="server" />
                    </td>
                   <td>
                       Add
                   </td>
                   <td>
                       <asp:Label ID="addNum1Label" RunAt="server"  Visible="false" Text="Num 1 : "/> 
                       <asp:TextBox ID="ComAdd1" RunAt="server" Visible="false"/>
                   </td>
                   <td>
                       <asp:TextBox ID="ComAdd2" RunAt="server"  Visible="false"/>
                   </td>
               </tr>

               <tr>
                   <td>
                       </td>
                   <td>
                       </td>
                   <td>
                       <asp:Label ID="addNum2Label" RunAt="server"  Visible="false" Text="Num 2 : "/>
                       <asp:TextBox ID="ComAdd3" RunAt="server" Visible="false"/>
                   </td>
                   <td>
                       <asp:TextBox ID="ComAdd4" RunAt="server"  Visible="false"/>
                   </td>
                   <td>
                       <asp:Button Text="  =  " RunAt="server" Visible="false" ID="ComplexAddButton" OnClick="ComplexAdd_Click" />
                   </td>
                   <td>
                       <asp:Label ID="ComplexAdd1" RunAt="server"  Visible="False"/>
                       <asp:Label ID="ComplexAdd2" RunAt="server"  Visible="False"/>
                   </td>
               </tr>

               <tr>
                    <td>
                            <asp:CheckBox ID="ComSubCheckBox" RunAt="server" />
                    </td>
                   <td>
                       Subtract
                   </td>
                   <td>
                       <asp:Label ID="subNum1Label" RunAt="server"  Visible="false" Text="Num 1 : "/>
                       <asp:TextBox ID="ComSub1" RunAt="server" Visible="false"/>
                   </td>
                   <td>
                       <asp:TextBox ID="ComSub2" RunAt="server"  Visible="false"/>
                   </td>
               </tr>

               <tr>
                   <td>
                       </td>
                   <td>
                       </td>
                   <td>
                       <asp:Label ID="subNum2Label" RunAt="server"  Visible="false" Text="Num 2 : "/>
                       <asp:TextBox ID="ComSub3" RunAt="server" Visible="false"/>
                   </td>
                   <td>
                       <asp:TextBox ID="ComSub4" RunAt="server"  Visible="false"/>
                   </td>
                   <td>
                       <asp:Button Text="  =  " RunAt="server" Visible="false" ID="ComplexSubButton" OnClick="ComplexSub_Click" />
                   </td>
                   <td>
                       <asp:Label ID="ComplexSub1" RunAt="server"  Visible="False"/>
                       <asp:Label ID="ComplexSub2" RunAt="server"  Visible="False"/>
                   </td>
               </tr>

               <tr>
                    <td>
                            <asp:CheckBox ID="ComDivCheckBox" RunAt="server" />
                    </td>
                   <td class="auto-style1">
                       Divide
                   </td>
                   <td>
                       <asp:Label ID="divNum1Label" RunAt="server"  Visible="false" Text="Num 1 : "/>
                       <asp:TextBox ID="ComDiv1" RunAt="server" Visible="false"/>
                   </td>
                   <td>
                       <asp:TextBox ID="ComDiv2" RunAt="server"  Visible="false"/>
                   </td>
                </tr>

               <tr>
                   <td>
                       </td>
                   <td>
                       </td>
                   <td>
                       <asp:Label ID="divNum2Label" RunAt="server"  Visible="false" Text="Num 2 : "/>
                       <asp:TextBox ID="ComDiv3" RunAt="server" Visible="false"/>
                   </td>
                   <td>
                       <asp:TextBox ID="ComDiv4" RunAt="server"  Visible="false"/>
                   </td>
                   <td>
                       <asp:Button Text="  =  " RunAt="server" Visible="false" ID="ComplexDivButton" OnClick="ComplexDiv_Click" />
                   </td>
                   <td>
                       <asp:Label ID="ComplexDiv1" RunAt="server"  Visible="False"/>
                       <asp:Label ID="ComplexDiv2" RunAt="server"  Visible="False"/>
                   </td>
               </tr>

               <tr>
                    <td>
                             <asp:CheckBox ID="ComMulCheckBox" RunAt="server" />
                    </td>
                   <td class="auto-style1">
                       Multiply
                   </td>
                    <td>
                       <asp:Label ID="mulNum1Label" RunAt="server"  Visible="false" Text="Num 1: "/>
                       <asp:TextBox ID="ComMul1" RunAt="server" Visible="false"/>
                   </td>
                   <td>
                       <asp:TextBox ID="ComMul2" RunAt="server"  Visible="false"/>
                   </td>
               </tr>

                 <tr>
                   <td>
                       </td>
                   <td>
                       </td>
                   <td>
                       <asp:Label ID="mulNum2Label" RunAt="server"  Visible="false" Text="Num 2 : "/>
                       <asp:TextBox ID="ComMul3" RunAt="server" Visible="false"/>
                   </td>
                   <td>
                       <asp:TextBox ID="ComMul4" RunAt="server"  Visible="false"/>
                   </td>
                   <td>
                       <asp:Button Text="  =  " RunAt="server" Visible="false" ID="ComplexMulButton" OnClick="CompexMul_Click" />
                   </td>
                   <td>
                       <asp:Label ID="ComplexMul1" RunAt="server"  Visible="False"/>
                       <asp:Label ID="ComplexMul2" RunAt="server"  Visible="False"/>
                   </td>
               </tr>
           </table>
        
        <asp:Button Text="Build Calc" OnClick="OnBuildSimpleCalc" RunAt="server" ID="buildCalc" />

    </form>
  </body>
</html>

