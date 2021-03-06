﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="mpdItem.ascx.vb"
    Inherits="DotNetNuke.Modules.AgapeConnect.mpdItem" %>

<asp:HiddenField ID="hfQuestionId" runat="server" value="0" />
<asp:HiddenField ID="hfSectionId" runat="server" value="0" />
<div ID="pnlControlGroup" runat="server" class="control-group">
     <asp:Panel ID="pnlInsert" runat="server" Visible="false">
         <div class="mpd-insert">
            <asp:HyperLink ID="hlInsert" runat="server" CssClass="btn-insert" >Insert New Item</asp:HyperLink>
         </div>
             </asp:Panel>
    <asp:Panel ID="pnlDisplay" runat="server">
    <asp:Label ID="lblItemId" runat="server" class="version-number"></asp:Label>

    <asp:Label ID="lblItemName" runat="server" class="control-label mpd-item-name"></asp:Label>
    <asp:TextBox ID="tbEventName" runat="server" placeholder="Event Name" class="control-label conf" Visible="false"></asp:TextBox>
    <div class="controls">

      

        <div class="span2 mpdColumn">
            <div class="input-prepend">
                <asp:Label ID="lblCur" runat="server" class="add-on"></asp:Label>
                <asp:TextBox ID="tbMonthly" runat="server" placeholder="Monthly"  type="number" step="any" class="mpdInput numeric monthly" Enabled="false"></asp:TextBox>
                <asp:Panel ID="pnlNetTax" runat="server" class="net-tax" Visible="False">
                    (+<asp:Label ID="lblNetTax" runat="server" CssClass="net-tax-month">0</asp:Label>
                    tax)
                      <asp:HiddenField ID="hftax" runat="server" Value="0"  />
                </asp:Panel>

                <asp:HiddenField ID="hfFormula" runat="server" Value="" />
            </div>
           
        </div>

        <div class="span2 mpdColumn">
            <div class="input-prepend">
                <asp:Label ID="lblCur2" runat="server" class="add-on"></asp:Label>
                <asp:TextBox ID="tbYearly" runat="server" placeholder="Yearly" type="number" step="any"  class="mpdInput numeric yearly" Enabled="false"></asp:TextBox>
                <asp:Panel ID="pnlNetTax2" runat="server" class="net-tax" Visible="False">
                    (+<asp:Label ID="lblNetTax2" runat="server" CssClass="net-tax-year">0</asp:Label>
                    tax)
                </asp:Panel>
            </div>
        </div>

        <asp:Label ID="lblHelp" runat="server" class="help-inline mpd-help span5" ></asp:Label>
      

        <asp:HyperLink ID="btnEdit" runat="server" CssClass="btn-edit" Visible="false">Edit</asp:HyperLink>
        
    </div>
        </asp:Panel>
    <div style="clear: both;"></div>
    <asp:Panel ID="pnlEditItem" runat="server" class="alert alert-info mpd-edit" Style="display: none;">
        <div style="display: inline-block; padding: 0; width: 100%;">
            <div style="width: 33%; float: left;">
                <table width="100%">
                    <tr>
                        <td>Name:</td>
                        <td>
                            <asp:TextBox ID="tbName" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>ID:</td>
                        <td>
                            <div class="input-prepend">
                                <asp:Label ID="lblIdPrefix" runat="server" class="add-on"></asp:Label>
                                <asp:TextBox ID="tbNumber" runat="server" Width="20px" CssClass="numeric"></asp:TextBox>
                            </div>

                        </td>
                    </tr>
                    <tr>
                        <td>Help:</td>
                        <td>
                            <asp:TextBox ID="tbHelp" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                    </tr>
                </table>
            </div>
            <div style="width: 33%; float: left;">
                <table width="100%">
                    <tr>
                        <td>User Input:</td>
                        <td>

                            <asp:DropDownList ID="ddlMode" runat="server" CssClass="mpd-edit-mode">
                                <asp:ListItem Text="Monthly (GROSS)" Value="BASIC_MONTH" />
                                <asp:ListItem Text="Yearly (GROSS)" Value="BASIC_YEAR" />
                                <asp:ListItem Text="Monthly (NET)" Value="NET_MONTH" />
                                <asp:ListItem Text="Yearly (NET)" Value="NET_YEAR" />
                                <asp:ListItem Text="None (Calculated)" Value="CALCULATED" />

                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Minimum:</td>
                        <td>
                            <span class="badge badge-success valid" style="display: none;"><i class="icon-ok icon-white"></i></span>
                            <span class="badge badge-important invalid" style="display: none;"><i class="icon-remove icon-white"></i></span>

                            <div class="input-prepend">
                                <asp:Label ID="Label2" runat="server" class="add-on"><i>f</i></asp:Label>
                                <asp:TextBox ID="tbMin" runat="server" Width="150px"></asp:TextBox>

                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>Maximum:</td>

                        <td>
                            <span class="badge badge-success valid" style="display: none;"><i class="icon-ok icon-white"></i></span>
                            <span class="badge badge-important invalid" style="display: none;"><i class="icon-remove icon-white"></i></span>

                            <div class="input-prepend">
                                <asp:Label ID="Label1" runat="server" class="add-on"><i>f</i></asp:Label>
                                <asp:TextBox ID="tbMax" runat="server" Width="150px"></asp:TextBox>

                            </div>

                        </td>
                    </tr>
                    <tr>
                        <td>Account:</td>
                        <td>
                            <asp:DropDownList ID="ddlAccount" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </div>
            <div style="width: 34%; float: left;">
                <div style="width: 100%; display: none;" class="mpd-edit-formula mpd-edit-mode-detail">
                    <div class="input-prepend" style="width: 100%">
                        <asp:Label ID="Label" runat="server" class="add-on">formula</asp:Label>
                        <asp:TextBox ID="tbFormula" runat="server" TextMode="MultiLine" Width="270px" Rows="2"></asp:TextBox>



                    </div>

                    <div style="width: 100%; font-size: small;">
                        Example 1:  <span class="comment">12% of Items 1.1 and 1.2</span><div class="exFormula">({1.1} + {1.2}) * 0.12</div>
                        Example 2: <span class="comment">$6000 Tax Free - then 12% (Item 1.1)</span>
                        <div class="exFormula">Math.max( ( {1.1} - 6000) * 0.12), 0) </div>
                    </div>

                </div>

                <div style="width: 100%; display: none;" class="mpd-edit-net mpd-edit-mode-detail">
                    <div class="span1" style="width: 100px">Tax System:</div>
                    <asp:DropDownList ID="TaxOptions" runat="server" Width="150px" CssClass="mpd-tax-mode span1">
                        <asp:ListItem Text="Fixed Rate" Value="FIXED_RATE" />
                        <asp:ListItem Text="Fixed Amount" Value="FIXED_AMOUNT" />
                        <asp:ListItem Text="Tax Free Allowance" Value="ALLOWANCE" />
                        <asp:ListItem Text="Tax Bands" Value="BANDS" />
                        <asp:ListItem Text="Custom" Value="Custom" />
                    </asp:DropDownList>

                    <div  class="mpd-tax-rate mpd-tax-detail"  >
                         <div class="span1" style="width: 100px">Tax Rate:</div>
                        <asp:TextBox runat="server" id="tbRate" type="text" placeholder="Tax Rate" class="numeric span1 rate" style="width: 60px"  />%

                    </div>
                     <div  class="mpd-tax-fixed mpd-tax-detail" style="display: none;" >
                         <div class="span1" style="width: 100px">Tax Amount:</div>
                         <asp:TextBox runat="server" id="tbAmount" type="text" placeholder="Tax amount" style="width: 80px; " class="numeric span1 fixed" />

                     </div>
                    <div class="mpd-tax-allowance mpd-tax-detail" style="display:none;">
                        <div>
                         <div class="span1" style="width: 100px">Threshold:</div>
                        <asp:TextBox runat="server" id="tbAllowance" type="text" placeholder="Tax Free Allowance" style="width: 130px" class="numeric span1 threshold" />
                        </div>
                        <div>
                             <div class="span1" style="width: 100px">Tax Rate:</div>
                        <asp:TextBox runat="server" id="tbAllowanceRate" type="text" placeholder="Tax Rate" style="width: 60px" class="numeric span1 rate" />%
                            </div>
                    </div>

                    <table class="mpd-tax-bands mpd-tax-detail" cellpadding="2px" style="display: none;">
                        <tr>
                            <td align="right">Up To:</td>
                            <td>
                                <asp:TextBox runat="server"  id="tbThreshold1" type="text" placeholder="Threshold1" style="width: 80px" class="numeric threshold1" /></td>
                            <td>
                                <asp:TextBox runat="server"  id="tbRate1" type="text" placeholder="Tax Rate" style="width: 60px" class="numeric rate1" />%</td>
                        </tr>
                        <tr>
                            <td align="right">Then upto:</td>
                            <td>
                                <asp:TextBox runat="server"  id="tbThreshold2" type="text" placeholder="Threshold1" style="width: 80px" class="numeric threshold2" /></td>
                            <td>
                                <asp:TextBox runat="server"  id="tbRate2" type="text" placeholder="Tax Rate" style="width: 60px" class="numeric rate2" />%</td>
                        </tr>
                        <tr>
                            <td align="right">Then upto:</td>
                            <td>
                                <asp:TextBox runat="server"  id="tbThreshold3" type="text" placeholder="Threshold1" style="width: 80px" class="numeric threshold3" /></td>
                            <td>
                                <asp:TextBox runat="server"  id="tbRate3" type="text" placeholder="Tax Rate" style="width: 60px" class="numeric rate3" />%</td>
                        </tr>
                        <tr>
                            <td align="right"   >Then upto:</td>
                            <td>
                               <i>unlimited</i></td>
                            <td>
                                <asp:TextBox runat="server"  id="tbRate4" type="text" placeholder="Tax Rate" style="width: 60px" class="numeric rate4" />%</td>
                        </tr>
                    </table>

                    
                  <div class="input-prepend " style="width: 100%; margin-top: 5px;">
                        <asp:Label ID="Label3" runat="server" class="add-on">formula</asp:Label>
                        <asp:TextBox ID="tbTaxFormula"   runat="server" CssClass="tax-formula" TextMode="MultiLine" Width="270px" Rows="2" readonly="True"></asp:TextBox>
                      <asp:HiddenField ID="hfTaxFormula" runat="server"  />


                    </div>
                        
                     <div class="tax-custom-help" style="width: 100%; font-size: small; display: none;">
                        Example: <span class="comment">$6000 Tax Free - then 12% </span>
                        <div class="exFormula">Math.max( ( {NET} - 6000) * 0.12), 0) </div>
                    </div>

                </div>



            </div>


        </div>
        <div style="width: 100%; text-align: center; padding: 5px;">
            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" formnovalidate />
            &nbsp;&nbsp;
             <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn" formnovalidate />
            &nbsp;&nbsp;
            <input type="button" id="edit-cancel" class="btn edit-cancel" value="Cancel"  />    &nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server">Guide to Advanced Formulas</asp:HyperLink>
        </div>
    </asp:Panel>

</div>
