<?php 
  $login = $_POST['cpf'];
  $entrar = $_POST['entrar'];
  $senha = $_POST['senha'];
  
  include 'conectabanco.php';
  
  $query = "select * from paciente where cpf='$login'";

  $resultado = mysql_query($query);

  $row = mysql_fetch_assoc($resultado);
  
	if (isset($entrar)) {
            
      $verifica = mysql_query("SELECT * FROM paciente WHERE cpf = '$login' AND senha = '$senha'") or die("erro ao selecionar");
        if (mysql_num_rows($verifica)<=0){
          echo"<script language='javascript' type='text/javascript'>alert('Login e/ou senha incorretos');window.location.href='loginp.php';</script>";
          die();
        }else{
          setcookie("login",$login);
          header("Location:dashp.php?cpf=$row[cpf]");
        }
    }
?>