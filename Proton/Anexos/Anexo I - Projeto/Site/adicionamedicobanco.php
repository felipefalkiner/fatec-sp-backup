<head>

<title>Untitled Document</title>
</head>

<body>

<center>

<?php 

	include 'conectabanco.php';





$nomemed	= $_POST ["nomemed"];
$senhamed	= $_POST ["senhamed"];
$cpfmed	= $_POST ["crmmed"];

$verifica = mysql_query("SELECT * FROM medico WHERE crm = '$cpfmed'") or die("erro ao selecionar");
        if (mysql_num_rows($verifica)!=0){
          echo"<script language='javascript' type='text/javascript'>alert('Esse CRM já esta cadastrado. O processo foi cancelado.');window.location.href='adicionamedico.php';</script>";
		die();}


$query = "INSERT INTO `medico` (`idmedico`, `senha`, `nome`, `crm`) VALUES (NULL, '$senhamed', '$nomemed', '$cpfmed');";

mysql_query($query,$conexao);

?>

<script type="text/javascript">   
function Redirect() 
{  
window.location="dashm.php"; 
} 
document.write("Cadastro de Profissional realizado com sucesso. <br> Voltando para o Menu Inicial."); 
setTimeout('Redirect()', 5000);   
</script>

<!--
ISSO É UM EXEMPLO DE INSERT

INSERT INTO `paciente` (`idpaciente`, `nome`, `senha`, `cpf`, `sexo`, `idade`, `datanasc`, `telefone`, `celular`, `emerg_nome`, `emerg_tel`, `emerg_cel`, `lesoes`, `lesoes_cm`, `fumante`, `marcapasso`, `marcapasso_cm`, `hipertensao`, `hipertensao_cm`, `epilepsia`, `epilepsia_cm`, `atfisica`, `atfisica_cm`, `alergic`, `alergic_cm`, `diabetes`, `diabetes_cm`) VALUES (NULL, 'Felipe', 'c3x2z1', '123456789', 'Masculino', '52', '10/20/3000', '111111111', '11111111', 'David', '1111111', '111111', '2', '', '2', '2', '', '2', '', '2', '', '2', '', '2', '', '2', '');

ESSE DEVE SER O INSERT PARA O PHP

INSERT INTO `paciente` (`idpaciente`, `nome`, `senha`, `cpf`, `sexo`, `idade`, `datanasc`, `telefone`, `celular`, `emerg_nome`, `emerg_tel`, `emerg_cel`, `lesoes`, `lesoes_cm`, `fumante`, `marcapasso`, `marcapasso_cm`, `hipertensao`, `hipertensao_cm`, `epilepsia`, `epilepsia_cm`, `atfisica`, `atfisica_cm`, `alergic`, `alergic_cm`, `diabetes`, `diabetes_cm`) VALUES (NULL, '$nomepac', '$senhapac', '$cpfpac', '$sexopac', '$idadepac', '$datapac', '$telpac', '$celpac', '$nomece', '$telce', 'celce', '$lesao', '$lesaotext', '$fumante', '$marcapasso', '$marcatext', '$hipertensao', '$hipertext', '$epilepsia', '$epileptext', '$fisica', '$fisicatext', '$alergicos', '$alergictext', '$diabetes', '$diabetext');
!-->





</center>
</body>
</html>
