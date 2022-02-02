<head>

<title>Untitled Document</title>
</head>

<body>

<center>

<?php 

	include 'conectabanco.php';


$nomepac	= $_POST ["nomepac"];
$senhapac	= $_POST ["senhapac"];
$cpfpac	= $_POST ["cpfpac"];
$sexopac	= $_POST ["sexopac"];	
$idadepac	= $_POST ["idadepac"];	
$datapac	= $_POST ["datapac"];	
$telpac	= $_POST ["telpac"];	
$celpac	= $_POST ["celpac"];
	
$nomece	= $_POST ["nomece"];	
$telce	= $_POST ["telce"];	
$celce	= $_POST ["celce"];	



$query = "UPDATE `paciente` SET
`nome` = '$nomepac', 
`senha` = '$senhapac',  
`sexo` = '$sexopac', 
`idade` = '$idadepac', 
`datanasc` = '$datapac', 
`telefone` = '$telpac', 
`celular` = '$celpac', 
`emerg_nome` = '$nomece', 
`emerg_tel` = '$telce', 
`emerg_cel` = '$celce'

WHERE `paciente`.`cpf` = $cpfpac;";



mysql_query($query,$conexao);

?>

<script type="text/javascript">   
function Redirect() 
{  
window.location="dashp.php?cpf=<?php echo "$cpfpac"; ?>"; 
} 
document.write("Alterações realizadas com sucesso. <br> Voltando para o Menu Inicial."); 
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
