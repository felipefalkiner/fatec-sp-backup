<?php 
  $login = $_POST['login'];
  $entrar = $_POST['entrar'];
  $senha = $_POST['senha'];
  
  include 'conectabanco.php';
  
	if (isset($entrar)) {
            
      $verifica = mysql_query("SELECT * FROM medico WHERE crm = '$login' AND senha = '$senha'") or die("erro ao selecionar");
        if (mysql_num_rows($verifica)<=0){
          echo"<script language='javascript' type='text/javascript'>alert('Login e/ou senha incorretos');window.location.href='loginm.php';</script>";
          die();
        }else{
          setcookie("login",$login);
          header("Location:dashm.php");
        }
    }
?>