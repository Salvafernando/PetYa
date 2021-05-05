<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Salvador_Hernandez.Presentacion.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>Clínica Veterinaría San Camilo</title>
<link href="css/bootstrap.css" rel='stylesheet' type='text/css' />
<link href="css/style.css" rel='stylesheet' type='text/css' />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300,600,700,800' rel='stylesheet' type='text/css'>
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<script src="js/jquery.min.js"></script>
<!--<script src="js/jquery.easydropdown.js"></script>-->
<!--start slider -->
<link rel="stylesheet" href="css/fwslider.css" media="all">
<script src="js/jquery-ui.min.js"></script>
<script src="js/fwslider.js"></script>
<!--end slider -->
<script type="text/javascript">
        $(document).ready(function() {
            $(".dropdown img.flag").addClass("flagvisibility");

            $(".dropdown dt a").click(function() {
                $(".dropdown dd ul").toggle();
            });
                        
            $(".dropdown dd ul li a").click(function() {
                var text = $(this).html();
                $(".dropdown dt a span").html(text);
                $(".dropdown dd ul").hide();
                $("#result").html("Selected value is: " + getSelectedValue("sample"));
            });
                        
            function getSelectedValue(id) {
                return $("#" + id).find("dt a span.value").html();
            }

            $(document).bind('click', function(e) {
                var $clicked = $(e.target);
                if (! $clicked.parents().hasClass("dropdown"))
                    $(".dropdown dd ul").hide();
            });


            $("#flagSwitcher").click(function() {
                $(".dropdown img.flag").toggleClass("flagvisibility");
            });
        });
     </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
		<div class="container">
			<div class="row">
				<div class="col-md-12">
					 <div class="header-left">
						 <div class="logo">
							<a href="Inicio.aspx"><img src="images/logoSanCamilo.png" alt=""/></a>
						 </div>
						<div class="menu">
								<ul class="nav" id="nav">
                                    <li><a href="Login.aspx">Ingresar</a></li>
                                                                        
									<li><a href="CRUDUsuarios.aspx">Registrarse</a></li>
									<li><a href="F_Reservar.html">Reservar</a></li>
									<li><a href="F_QuienesSomos.html">Quienes Somos</a></li>
								</ul>
								<script type="text/javascript" src="js/responsive-nav.js"></script>
						</div>							
					</div>
				</div>
			 </div>
	    </div>
	</div>
	<div class="banner">
	<!-- start slider -->
       <div id="fwslider">
         <div class="slider_container">
            <div class="slide">
               <img src="images/Gatos.jpg" class="img-responsive" alt=""/>
                <div class="slide_content">
                    <div class="slide_content_wrap">
                        <h1 class="title">Clínica Veterinaria<br>San Camilo</h1>
                    </div>
                </div>
            </div>
            <div class="slide">
               <img src="images/Perro.jpg" class="img-responsive" alt=""/>
                <div class="slide_content">
                    <div class="slide_content_wrap">
                        <h1 class="title">Clínica Veterinaria<br>San Camilo</h1>
                    </div>
                </div>
            </div>
            <div class="slide">
               <img src="images/Perro2.jpg" class="img-responsive" alt=""/>
                <div class="slide_content">
                    <div class="slide_content_wrap">
                        <h1 class="title">Clínica Veterinaria<br>San Camilo</h1>
                    </div>
                </div>
            </div>
            <!--/slide -->
        </div>
        <div class="timers"></div>
        <div class="slidePrev"><span></span></div>
        <div class="slideNext"><span></span></div>
       </div>
       <!--/slider -->
	</div>
	<div class="footer">
		<div class="container">
			<div class="row">
				<div class="col-md-3">
					<ul class="footer_box">
						<h4>Redes Sociales</h4>
						<ul class="social">	
						  <li class="facebook"><a href="#"><span> </span></a></li>
						  <li class="twitter"><a href="#"><span> </span></a></li>
						  <li class="instagram"><a href="#"><span> </span></a></li>	
						  <li class="pinterest"><a href="#"><span> </span></a></li>	
						  <li class="youtube"><a href="#"><span> </span></a></li>										  				
						</ul>
					</ul>
				</div>
			</div>
		</div>
	</div>
    </form>
</body>
</html>
