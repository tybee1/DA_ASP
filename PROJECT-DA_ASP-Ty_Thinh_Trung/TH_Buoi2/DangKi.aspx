<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKi.aspx.cs" Inherits="TH_Buoi2.DangKi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8" />
        <title>Upvex - Responsive Admin Dashboard Template</title>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta content="A fully featured admin theme which can be used to build CRM, CMS, etc." name="description" />
        <meta content="Coderthemes" name="author" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <!-- App favicon -->
        <link rel="shortcut icon" href="assets/images/favicon.ico">

        <!-- App css -->
        <link href="assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
        <link href="assets/css/icons.min.css" rel="stylesheet" type="text/css" />
        <link href="assets/css/app.min.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <body class="authentication-bg authentication-bg-pattern">

        <div class="account-pages mt-5 mb-5">
            <div class="container">
                <div class="row justify-content-center">
                    <div class="col-md-8 col-lg-6 col-xl-5">
                        <div class="card">

                            <div class="card-body p-4">
                                
                                <div class="text-center w-75 m-auto">
                                    <a href="index.html">
                                        <span><img src="assets/images/logo-dark.png" alt="" height="26"></span>
                                    </a>
                                    <p class="text-muted mb-4 mt-3">Enter your email address and password to access admin panel.</p>
                                </div>

                                <h5 class="auth-title">Sign In</h5>

                                <form action="#">

                                    <div class="form-group mb-3">
                                        <label>Tên tài khoản</label>                                    
                                        <asp:TextBox ID="txtTenTaiKhoan" runat="server" CssClass="form-control" ></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTenTaiKhoan" ErrorMessage="Tài khoản không được bỏ trống!!!" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                                    </div>

                                    <div class="form-group mb-3">
                                        <label>Mật khẩu</label>
                                        <asp:TextBox ID="txtMatKhau" runat="server" CssClass="form-control" TextMode="Password" ></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMatKhau" ErrorMessage="Mật khảu không được bỏ trống!!!" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtMatKhau" ValidationExpression="\w{6,15}" ErrorMessage="Mật khẩu phải từ 6 đến 15 kí tự" CssClass="text-danger"></asp:RegularExpressionValidator>
                                    </div>
                                    
                                    <div class="form-group mb-3">
                                        <label>Email</label>                                    
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" ></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email không được bỏ trống!!!" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                                        
                                    </div>
                                    
                                    <div class="form-group mb-3">
                                        <label>Số điện thoại</label>                                    
                                        <asp:TextBox ID="txtSDT" runat="server" CssClass="form-control" ></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtSDT" ErrorMessage="Số điện thoại không được bỏ trống!!!" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtSDT" ErrorMessage="Số điện thoại không hợp lệ!!!" ValidationExpression="0\d{9}" CssClass="text-danger"></asp:RegularExpressionValidator>
                                    </div>
                                    
                                    <div class="form-group mb-3">
                                        <label>Địa chỉ</label>                                    
                                        <asp:TextBox ID="txtDiaChi" runat="server" CssClass="form-control" ></asp:TextBox>                                     
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtDiaChi" ErrorMessage="Địa chỉ không được bỏ trống!!!" CssClass="text-danger"></asp:RequiredFieldValidator>
                                    </div>
                                        <div class="form-group mb-3">
                                        <label>Họ Tên</label>                                    
                                        <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control" ></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtHoTen"  ErrorMessage="Họ tên không được bỏ trống!!!" CssClass="text-danger"></asp:RequiredFieldValidator>
                                    </div>
                                        <div class="form-group mb-3">
                                        <label>La Admin</label>                                    
                                            <asp:CheckBox ID="chkLaAdmin" runat="server"/>

                                    </div>
                                        <div class="form-group mb-3">
                                        <label>Ảnh đại diện</label>                                    
                                        <asp:TextBox ID="txtAnh" runat="server" CssClass="form-control" ></asp:TextBox>
                                    </div>
                                    <div class="form-group mb-3">
                                        <label>Trạng thái</label>                                    
                                            <asp:CheckBox ID="chkTrangThai" runat="server"  />
                                    </div>


                                    <div class="form-group mb-0 text-center"> 
                                        <asp:Button ID="btnDangKi" runat="server" Text="Đăng kí" CssClass="btn btn-danger btn-block" OnClick="btnDangKi_Click" />

                                    </div>
                                   

                                </form>

                                <div class="text-center">
                                   
                                    <ul class="social-list list-inline mt-3 mb-0">
                                        <li class="list-inline-item">
                                            <a href="javascript: void(0);" class="social-list-item border-primary text-primary"><i class="mdi mdi-facebook"></i></a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="javascript: void(0);" class="social-list-item border-danger text-danger"><i class="mdi mdi-google"></i></a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="javascript: void(0);" class="social-list-item border-info text-info"><i class="mdi mdi-twitter"></i></a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="javascript: void(0);" class="social-list-item border-secondary text-secondary"><i class="mdi mdi-github-circle"></i></a>
                                        </li>
                                    </ul>
                                </div>

                            </div> <!-- end card-body -->
                        </div>
                        <!-- end card -->

                        <div class="row mt-3">
                            <div class="col-12 text-center">
                                <p> <a href="pages-recoverpw.html" class="text-muted ml-1">Forgot your password?</a></p>
                                <p class="text-muted">Don't have an account? <a href="pages-register.html" class="text-muted ml-1"><b class="font-weight-semibold">Sign Up</b></a></p>
                            </div> <!-- end col -->
                        </div>
                        <!-- end row -->

                    </div> <!-- end col -->
                </div>
                <!-- end row -->
            </div>
            <!-- end container -->
        </div>
        <!-- end page -->


        <footer class="footer footer-alt">
            2019 &copy; Upvex theme by <a href="" class="text-muted">Coderthemes</a> 
        </footer>
 <!-- Vendor js -->
        <script src="assets/js/vendor.min.js"></script>

        <!-- App js -->
        <script src="assets/js/app.min.js"></script>
        
        </div>
    </form>
        </div>
    </form>
</body>
</html>
