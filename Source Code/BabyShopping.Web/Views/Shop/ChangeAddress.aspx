﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Payment.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    ChangeAddress
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="BoxTable" cellpadding="0" cellspacing="0" border="0" width="100%">
        <tr>
            <td class="BoxHeader">
                Change Address
            </td>
        </tr>
        <tr>
            <td class="FormDetailCell">
                <table class="TableFormInside" cellpadding="0" cellspacing="0" border="0">
                    <tr style="height: 60px;">
                        <td>
                            First Name
                        </td>
                        <td class="CellRight">
                            <input id="txtFirstName" type="text" runat="server" class="TextBox" maxlength="50" />*
                        </td>
                    </tr>
                    <tr style="height: 60px;">
                        <td class="CellLeft">
                            Last Name
                        </td>
                        <td class="CellRight">
                            <input id="txtLastName" type="text" runat="server" class="TextBox" maxlength="50" />
                        </td>
                    </tr>
                    <tr style="height: 60px;">
                        <td class="CellLeft">
                            Address
                        </td>
                        <td class="CellRight">
                            <input id="txtAddress" type="text" runat="server" class="TextBox" maxlength="200" />*
                        </td>
                    </tr>
                    <tr style="height: 60px;">
                        <td class="CellLeft">
                            City
                        </td>
                        <td class="CellRight">
                            <input id="txtCity" type="text" runat="server" class="TextBox" maxlength="50" />*
                        </td>
                    </tr>
                    <tr style="height: 60px;">
                        <td class="CellLeft">
                            State/Province
                        </td>
                        <td class="CellRight">
                            <input id="txtState" type="text" runat="server" class="TextBox" maxlength="50" />*
                        </td>
                    </tr>
                    <tr style="height: 60px;">
                        <td class="CellLeft">
                            Country
                        </td>
                        <td class="CellRight">
                            <select id="ddlCountry" runat="server" class="DropDown">
                                <option value='--Select--' selected="selected">--Select--</option>
                                <option value='Afghanistan'>Afghanistan</option>
                                <option value='Albania'>Albania</option>
                                <option value='Algeria'>Algeria</option>
                                <option value='American Samoa'>American Samoa</option>
                                <option value='Andorra'>Andorra</option>
                                <option value='Angola'>Angola</option>
                                <option value='Anguilla'>Anguilla</option>
                                <option value='Antarctica'>Antarctica</option>
                                <option value='Antigua and Barbuda'>Antigua and Barbuda</option>
                                <option value='Argentina'>Argentina</option>
                                <option value='Armenia'>Armenia</option>
                                <option value='Aruba'>Aruba</option>
                                <option value='Australia'>Australia</option>
                                <option value='Austria'>Austria</option>
                                <option value='Azerbaijan'>Azerbaijan</option>
                                <option value='Bahamas'>Bahamas</option>
                                <option value='Bahrain'>Bahrain</option>
                                <option value='Bangladesh'>Bangladesh</option>
                                <option value='Barbados'>Barbados</option>
                                <option value='Belarus'>Belarus</option>
                                <option value='Belgium'>Belgium</option>
                                <option value='Belize'>Belize</option>
                                <option value='Benin'>Benin</option>
                                <option value='Bermuda'>Bermuda</option>
                                <option value='Bhutan'>Bhutan</option>
                                <option value='Bolivia'>Bolivia</option>
                                <option value='Bosnia and Herzegovina'>Bosnia and Herzegovina</option>
                                <option value='Botswana'>Botswana</option>
                                <option value='Bouvet Island'>Bouvet Island</option>
                                <option value='Brazil'>Brazil</option>
                                <option value='British Indian Ocean Territory'>British Indian Ocean Territory</option>
                                <option value='British Virgin Islands'>British Virgin Islands</option>
                                <option value='Brunei'>Brunei</option>
                                <option value='Bulgaria'>Bulgaria</option>
                                <option value='Burkina Faso'>Burkina Faso</option>
                                <option value='Burundi'>Burundi</option>
                                <option value='Cambodia'>Cambodia</option>
                                <option value='Cameroon'>Cameroon</option>
                                <option value='Canada'>Canada</option>
                                <option value='Cape Verde'>Cape Verde</option>
                                <option value='Cayman Islands'>Cayman Islands</option>
                                <option value='Central African Republic'>Central African Republic</option>
                                <option value='Chad'>Chad</option>
                                <option value='Chile'>Chile</option>
                                <option value='China'>China</option>
                                <option value='Christmas Island'>Christmas Island</option>
                                <option value='Cocos Islands'>Cocos Islands</option>
                                <option value='Colombia'>Colombia</option>
                                <option value='Comoros'>Comoros</option>
                                <option value='Congo'>Congo</option>
                                <option value='Cook Islands'>Cook Islands</option>
                                <option value='Costa Rica'>Costa Rica</option>
                                <option value='Croatia'>Croatia</option>
                                <option value='Cuba'>Cuba</option>
                                <option value='Cyprus'>Cyprus</option>
                                <option value='Czech Republic'>Czech Republic</option>
                                <option value='Denmark'>Denmark</option>
                                <option value='Djibouti'>Djibouti</option>
                                <option value='Dominica'>Dominica</option>
                                <option value='Dominican Republic'>Dominican Republic</option>
                                <option value='East Timor'>East Timor</option>
                                <option value='Ecuador'>Ecuador</option>
                                <option value='Egypt'>Egypt</option>
                                <option value='El Salvador'>El Salvador</option>
                                <option value='Equatorial Guinea'>Equatorial Guinea</option>
                                <option value='Eritrea'>Eritrea</option>
                                <option value='Estonia'>Estonia</option>
                                <option value='Ethiopia'>Ethiopia</option>
                                <option value='Falkland Islands'>Falkland Islands</option>
                                <option value='Faroe Islands'>Faroe Islands</option>
                                <option value='Fiji'>Fiji</option>
                                <option value='Finland'>Finland</option>
                                <option value='France'>France</option>
                                <option value='French Guiana'>French Guiana</option>
                                <option value='French Polynesia'>French Polynesia</option>
                                <option value='French Southern Territories'>French Southern Territories</option>
                                <option value='Gabon'>Gabon</option>
                                <option value='Gambia'>Gambia</option>
                                <option value='Georgia'>Georgia</option>
                                <option value='Germany'>Germany</option>
                                <option value='Ghana'>Ghana</option>
                                <option value='Gibraltar'>Gibraltar</option>
                                <option value='Greece'>Greece</option>
                                <option value='Greenland'>Greenland</option>
                                <option value='Grenada'>Grenada</option>
                                <option value='Guadeloupev'>Guadeloupev</option>
                                <option value='Guam'>Guam</option>
                                <option value='Guatemala'>Guatemala</option>
                                <option value='Guinea'>Guinea</option>
                                <option value='Guinea-Bissau'>Guinea-Bissau</option>
                                <option value='Guyana'>Guyana</option>
                                <option value='Haiti'>Haiti</option>
                                <option value='Heard and McDonald Islands'>Heard and McDonald Islands</option>
                                <option value='Honduras'>Honduras</option>
                                <option value='Hong Kong'>Hong Kong</option>
                                <option value='Hungary'>Hungary</option>
                                <option value='Iceland'>Iceland</option>
                                <option value='India'>India</option>
                                <option value='Indonesia'>Indonesia</option>
                                <option value='Iran'>Iran</option>
                                <option value='Iraq'>Iraq</option>
                                <option value='Ireland'>Ireland</option>
                                <option value='Israel'>Israel</option>
                                <option value='Italy'>Italy</option>
                                <option value='Ivory Coast'>Ivory Coast</option>
                                <option value='Jamaica'>Jamaica</option>
                                <option value='Japan'>Japan</option>
                                <option value='Jordan'>Jordan</option>
                                <option value='Kazakhstan'>Kazakhstan</option>
                                <option value='Kenya'>Kenya</option>
                                <option value='Kiribati'>Kiribati</option>
                                <option value='Korea, North'>Korea, North</option>
                                <option value='Korea, South'>Korea, South</option>
                                <option value='Kuwait'>Kuwait</option>
                                <option value='Kyrgyzstan'>Kyrgyzstan</option>
                                <option value='Laos'>Laos</option>
                                <option value='Latvia'>Latvia</option>
                                <option value='Lebanon'>Lebanon</option>
                                <option value='Lesotho'>Lesotho</option>
                                <option value='Liberia'>Liberia</option>
                                <option value='Libya'>Libya</option>
                                <option value='Liechtenstein'>Liechtenstein</option>
                                <option value='Lithuania'>Lithuania</option>
                                <option value='Luxembourg'>Luxembourg</option>
                                <option value='Malaysia'>Malaysia</option>
                                <option value='Maldives'>Maldives</option>
                                <option value='Mali'>Mali</option>
                                <option value='Mongolia'>Mongolia</option>
                                <option value='Montserrat'>Montserrat</option>
                                <option value='Morocco'>Morocco</option>
                                <option value='Mozambique'>Mozambique</option>
                                <option value='Myanmar'>Myanmar</option>
                                <option value='Namibia'>Namibia</option>
                                <option value='Nauru'>Nauru</option>
                                <option value='Nepal'>Nepal</option>
                                <option value='Netherlands'>Netherlands</option>
                                <option value='Netherlands Antilles'>Netherlands Antilles</option>
                                <option value='New Caledonia'>New Caledonia</option>
                                <option value='New Zealand'>New Zealand</option>
                                <option value='Nicaragua'>Nicaragua</option>
                                <option value='Niger'>Niger</option>
                                <option value='Nigeria'>Nigeria</option>
                                <option value='Niue'>Niue</option>
                                <option value='Norfolk Island'>Norfolk Island</option>
                                <option value='Northern Mariana Islands'>Northern Mariana Islands</option>
                                <option value='Norway'>Norway</option>
                                <option value='Oman'>Oman</option>
                                <option value='Pakistan'>Pakistan</option>
                                <option value='Palau'>Palau</option>
                                <option value='Panama'>Panama</option>
                                <option value='Papua New Guinea'>Papua New Guinea</option>
                                <option value='Paraguay'>Paraguay</option>
                                <option value='Peru'>Peru</option>
                                <option value='Philippines'>Philippines</option>
                                <option value='Pitcairn Island'>Pitcairn Island</option>
                                <option value='Poland'>Poland</option>
                                <option value='Portugal'>Portugal</option>
                                <option value='Puerto Rico'>Puerto Rico</option>
                                <option value='Qatar'>Qatar</option>
                                <option value='Reunion'>Reunion</option>
                                <option value='Romania'>Romania</option>
                                <option value='Russia'>Russia</option>
                                <option value='Rwanda'>Rwanda</option>
                                <option value='S. Georgia and S. Sandwich Isls'>S. Georgia and S. Sandwich Isls</option>
                                <option value='Saint Kitts and Nevis'>Saint Kitts and Nevis</option>
                                <option value='Saint Lucia'>Saint Lucia</option>
                                <option value='Saint Vincent and The Grenadines'>Saint Vincent and The Grenadines</option>
                                <option value='Samoa'>Samoa</option>
                                <option value='San Marino'>San Marino</option>
                                <option value='Sao Tome and Principe'>Sao Tome and Principe</option>
                                <option value='Saudi Arabia'>Saudi Arabia</option>
                                <option value='Senegal'>Senegal</option>
                                <option value='Seychelles'>Seychelles</option>
                                <option value='Sierra Leone'>Sierra Leone</option>
                                <option value='Singapore'>Singapore</option>
                                <option value='Slovakia'>Slovakia</option>
                                <option value='Slovenia'>Slovenia</option>
                                <option value='Somalia'>Somalia</option>
                                <option value='South Africa'>South Africa</option>
                                <option value='Spain'>Spain</option>
                                <option value='Sri Lanka'>Sri Lanka</option>
                                <option value='St. Helena'>St. Helena</option>
                                <option value='St. Pierre and Miquelon'>St. Pierre and Miquelon</option>
                                <option value='Sudan'>Sudan</option>
                                <option value='Suriname'>Suriname</option>
                                <option value='Svalbard and Jan Mayen Islands'>Svalbard and Jan Mayen Islands</option>
                                <option value='Swaziland'>Swaziland</option>
                                <option value='Sweden'>Sweden</option>
                                <option value='Switzerland'>Switzerland</option>
                                <option value='Syria'>Syria</option>
                                <option value='Taiwan'>Taiwan</option>
                                <option value='Tajikistan'>Tajikistan</option>
                                <option value='Tanzania'>Tanzania</option>
                                <option value='Thailand'>Thailand</option>
                                <option value='Togo'>Togo</option>
                                <option value='Tokelau'>Tokelau</option>
                                <option value='Tonga'>Tonga</option>
                                <option value='Trinidad and Tobago'>Trinidad and Tobago</option>
                                <option value='Tunisia'>Tunisia</option>
                                <option value='Turkey'>Turkey</option>
                                <option value='Turkmenistan'>Turkmenistan</option>
                                <option value='Turks and Caicos Islands'>Turks and Caicos Islands</option>
                                <option value='Tuvalu'>Tuvalu</option>
                                <option value='Uganda'>Uganda</option>
                                <option value='Ukraine'>Ukraine</option>
                                <option value='United Arab Emirates'>United Arab Emirates</option>
                                <option value='United Kingdom'>United Kingdom</option>
                                <option value='United States of America'>United States of America</option>
                                <option value='Uruguay'>Uruguay</option>
                                <option value='Uzbekistan'>Uzbekistan</option>
                                <option value='Vanuatu'>Vanuatu</option>
                                <option value='Vatican City'>Vatican City</option>
                                <option value='Venezuela'>Venezuela</option>
                                <option value='Vietnam'>Vietnam</option>
                                <option value='Virgin Islands'>Virgin Islands</option>
                                <option value='Wallis and Futuna Islands'>Wallis and Futuna Islands</option>
                                <option value='Western Sahara'>Western Sahara</option>
                                <option value='Yemen'>Yemen</option>
                                <option value='Yugoslavia (Former)'>Yugoslavia (Former)</option>
                                <option value='Zaire'>Zaire</option>
                                <option value='Zambia'>Zambia</option>
                                <option value='Zimbabwe'>Zimbabwe</option>
                            </select>*
                        </td>
                    </tr>
                    <tr style="height: 60px;">
                        <td class="CellLeft">
                            Zip/Postal
                        </td>
                        <td class="CellRight">
                            <input id="txtZip" type="text" runat="server" class="TextBox" maxlength="6" />*
                        </td>
                    </tr>
                    <tr style="height: 60px;">
                        <td class="CelLeft" style="width: 20%;">
                        </td>
                        <td class="CellRight" style="width: 80%;">
                            <input type="submit" class="e-button e-button-signup" style="width: 20%; position: relative;
                                left: 0%;" name="address" id="address" value="Change Address" title="Change Address::BabyShop" />
                            <a href="#" class="link-button-regular" title="Back::BabyShop" onclick="javascript:fnBack();">
                                Back</a>
                        </td>
                    </tr>
                    <tr>
                        <td class="AbowLine" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="CellLine" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="BelowLine" colspan="2">
                            *Required field(s)
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="BoxFooterLeft">
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
