<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>SignIn @ IT Gopeshwar</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="css/linkhover.css" rel="stylesheet" />

    <link href="mdl/material.min.css" rel="stylesheet" />
    <!--===============================================================================================-->
    <link rel="icon" type="image/png" href="images/icons/favicon.ico" />
    <!--===============================================================================================-->
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="fonts/Linearicons-Free-v1.0.0/icon-font.min.css">
    <!--===============================================================================================-->
    <!--====================================================for spacing between textbox and linkss======-->
    <link rel="stylesheet" type="text/css" href="css/util.css">
    <link rel="stylesheet" type="text/css" href="css/main.css">
    <link href="css/loadingstyle.css" rel="stylesheet" />
    <!--===============================================================================================-->
</head>
<body>
    <div class="limiter">
        <div class="container-login100">
            <div class="wrap-login100">
                <div class="wrapper">
                    <div class="login100-form-title" style="background-image: url(images/bg-01.jpg);">
                        <span class="login100-form-title-1">Sign In
                        </span>
                    </div>

                    <form runat="server" class="login100-form validate-form">
                        <div class="wrap-input100 validate-input m-b-26" data-validate="Username is required">
                            <span class="label-input100">Username</span>
                            <asp:TextBox ID="username" runat="server" class="input100" BorderStyle="None"></asp:TextBox>
                            <span class="focus-input100"></span>
                        </div>

                        <div class="wrap-input100 validate-input m-b-18" data-validate="Password is required">
                            <span class="label-input100">Password</span>

                            <asp:TextBox ID="password" runat="server" class="input100" TextMode="Password" BorderStyle="None"></asp:TextBox>
                            <span class="focus-input100"></span>
                        </div>

                        <div class="flex-sb-m w-full p-b-30">

                            <button id="demo-show-toast" type="button" class="mdl-button--accent">Forget Password?</button>
                            <div id="demo-toast-example" class="mdl-js-snackbar mdl-snackbar">
                                <div class="mdl-snackbar__text"></div>
                                <button class="mdl-snackbar__action" type="button"></button>
                            </div>

                        </div>

                        <div class="container-login100-form-btn">
                            <asp:Button ID="Button1" runat="server" class="login100-form-btn" Text="Login" OnClick="Button1_Click" Height="43px" Width="71px" />

                        </div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    
                    <div class="flex-sb-m w-full">

                        <div>
                            <a href="Registration.aspx" class="txt2">Student Registration
                            </a>
                        </div>
                        <div>
                            <a href="FacultyRegistration.aspx" class="txt2">Faculty Registration
                            </a>
                        </div>
                        <div>
                        </div>
                    </div>
                    </form>
                </div>
            </div>
        </div>

    </div>
    <%--for website loader--%>
    <div class="loader-wrapper">
        <div class="loader"></div>
    </div>
    <script src="js/loadingscript.js"></script>


    <script>
        (function () {
            'use strict';
            window['counter'] = 0;
            var snackbarContainer = document.querySelector('#demo-toast-example');
            var showToastButton = document.querySelector('#demo-show-toast');
            showToastButton.addEventListener('click', function () {
                'use strict';
                var data = { message: "Kindly contact the administrator" };
                snackbarContainer.MaterialSnackbar.showSnackbar(data);
            });
        }());
    </script>
    <!--================================================================================for error provide and handling===============-->
    <script src="vendor/jquery/jquery-3.2.1.min.js"></script>
    <script src="mdl/material.min.js"></script>
    <script src="js/main.js"></script>
</body>
</html>


