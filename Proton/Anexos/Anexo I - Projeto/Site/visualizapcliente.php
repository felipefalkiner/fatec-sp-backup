<html><head>
        <title>ProtOn - Prontuario Online</title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <script type="text/javascript" src="http://cdnjs.cloudflare.com/ajax/libs/jquery/2.0.3/jquery.min.js"></script>
        <script type="text/javascript" src="bootstrap.min.js"></script>
        <link href="http://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet" type="text/css">
        <link href="style.css" rel="stylesheet" type="text/css">
		
		<script type="text/javascript">
function validaCampo()
{
if(document.paciente.nomepac.value=="")
	{
	alert("O campo Nome é obrigatório!");
	return false;
	}
else
	if(document.paciente.senhapac.value=="")
	{
	alert("O campo Senha é obrigatório!");
	return false;
	}
else
	if(document.paciente.cpfpac.value=="")
	{
	alert("O campo CPF é obrigatório!");
	return false;
	}
else	
if(document.paciente.idadepac.value=="")
	{
	alert("O campo Idade é obrigatório!");
	return false;
	}
else
return true;
}
</script>		
    </head><body>
	
	<?php
	
	include 'conectabanco.php';
	
$cpfg = $_GET["cpf"];

$query = "select * from paciente where cpf='$cpfg'";

$resultado = mysql_query($query);


$row = mysql_fetch_assoc($resultado);

?>
	
        <div class="navbar navbar-default navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <a class="navbar-brand"><span>ProtoOn</span></a>
                </div>
                <div class="collapse navbar-collapse" id="navbar-ex-collapse">
                </div>
            </div>
        </div>
        <div class="section">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <h1 class="text-center">Visualizando Paciente
                            <br>
                        </h1>
                    </div>
                </div>
            </div>
        </div>
        <div class="section">
            <div class="container">
                <div class="row">
                    <div class="col-md-6">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <h3 class="panel-title">Dados Pessoais</h3>
                            </div>
                            <div class="panel-body">
                                <form id="paciente" name="paciente" role="form" method="post" action="alterapbanco.php" onsubmit="return validaCampo()">
                                    <div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Nome</label>
                                        <input readonly class="form-control" name="nomepac" id="nomepac" placeholder="" type="text" value="<?php echo $row["nome"]; ?>">
                                    </div>
									<div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Senha</label>
                                        <input readonly class="form-control" name="senhapac" id="senhapac" placeholder="" type="text" value="<?php echo $row["senha"]; ?>">
                                    </div>
									<div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">CPF</label>
                                        <input readonly class="form-control" name="cpfpac" id="cpfpac" placeholder="" type="text" value="<?php echo $row["cpf"]; ?>" readonly>
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Sexo</label>
                                        <input readonly class="form-control" name="sexopac" id="sexopac" placeholder="" type="text" value="<?php echo $row["sexo"]; ?>">
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Idade</label>
                                        <input readonly class="form-control" name="idadepac" id="idadepac" placeholder="" type="text" value="<?php echo $row["idade"]; ?>">
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Data de Nascimento</label>
                                        <input readonly class="form-control" name="datapac" id="datapac" placeholder="" type="text" value="<?php echo $row["datanasc"]; ?>">
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Telefone</label>
                                        <input readonly class="form-control" name="telpac" id="telpac" placeholder="" type="text" value="<?php echo $row["telefone"]; ?>">
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Celular</label>
                                        <input readonly class="form-control" name="celpac" id="celpac" placeholder="" type="text" value="<?php echo $row["celular"]; ?>">
                                    </div>
                                
                            </div>
                        </div>
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <h3 class="panel-title">Contato de Emergência</h3>
                            </div>
                            <div class="panel-body">
                                <div class="form-group">
                                    <label class="control-label" for="exampleInputEmail1">Nome</label>
                                    <input readonly class="form-control" name="nomece" id="nomece" placeholder="" type="text" value="<?php echo $row["emerg_nome"]; ?>">
                                </div>
                                <div class="form-group">
                                    <label class="control-label" for="exampleInputEmail1">Telefone</label>
                                    <input readonly class="form-control" name="telce" id="telce" placeholder="" type="text" value="<?php echo $row["emerg_tel"]; ?>">
                                </div>
                                <div class="form-group">
                                    <label class="control-label" for="exampleInputEmail1">Celular</label>
                                    <input readonly class="form-control" name="celce" id="celce" placeholder="" type="text" value="<?php echo $row["emerg_cel"]; ?>">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <h3 class="panel-title">Histórico</h3>
                            </div>
                            <div class="panel-body">
                                <ol class="list-unstyled text-left">
                                    <li style="font-weight: bold;">Lesões?</li>
                                    <input disabled type="radio" name="lesao" value="1" <?php if ($row["lesoes"] == 1) {echo "checked";} ?>>
									Sim
                                    <input disabled style="margin-left:10px;" type="radio" name="lesao" value="2" <?php if ($row["lesoes"] == 2) {echo "checked";} ?>>
									Não
                                    <br>
									<br><li><strong>Observação:</strong> <?php echo $row["lesoes_cm"]; ?></li> <br>
									<!--
                                    <input readonly type="text" name="lesaotext" id="lesaotext" value=""> !-->
                                    <li style="font-weight: bold;">Fumante?</li>
                                    <input disabled type="radio" name="fumante" value="1" <?php if ($row["fumante"] == 1) {echo "checked";} ?>>Sim
                                    <input disabled style="margin-left:10px;" type="radio" name="fumante" value="2" <?php if ($row["fumante"] == 2) {echo "checked";} ?> >Não
                                    <br>
                                    <br><li style="font-weight: bold;">Portador de Marcapasso?</li>
                                    <input disabled type="radio" name="marcapasso" value="1" <?php if ($row["marcapasso"] == 1) {echo "checked";} ?>>Sim
                                    <input disabled style="margin-left:10px;" type="radio" name="marcapasso" value="2" <?php if ($row["marcapasso"] == 2) {echo "checked";} ?> >Não
                                    <br>
									<br><li><strong>Observação:</strong> <?php echo $row["marcapasso_cm"]; ?></li> <br>
                                    <li style="font-weight: bold;">Hipertensão?</li>
                                    <input disabled type="radio" name="hipertensao" value="1" <?php if ($row["hipertensao"] == 1) {echo "checked";} ?>>Sim
                                    <input disabled type="radio" value="2" style="margin-left:10px;" name="hipertensao" <?php if ($row["hipertensao"] == 2) {echo "checked";} ?>>Não
                                    <br>
									<br><li><strong>Observação:</strong> <?php echo $row["hipertensao_cm"]; ?></li><br>
                                    <li style="font-weight: bold;">Epilepsia?</li>
                                    <input disabled type="radio" name="epilepsia" value="1" <?php if ($row["epilepsia"] == 1) {echo "checked";} ?>>Sim
                                    <input disabled style="margin-left:10px;" type="radio" name="epilepsia" value="2" <?php if ($row["epilepsia"] == 2) {echo "checked";} ?> >Não
                                    <br>
									<br><li><strong>Observação:</strong> <?php echo $row["epilepsia_cm"]; ?></li><br>
                                    
                                    <li style="font-weight: bold;">Pratica atividade física?</li>
                                    <input disabled type="radio" name="fisica" value="1" <?php if ($row["atfisica"] == 1) {echo "checked";} ?>>Sim
                                    <input disabled style="margin-left:10px;" type="radio" name="fisica" value="2" <?php if ($row["atfisica"] == 2) {echo "checked";} ?> >Não
                                    <br>
                                    <br><li><strong>Observação:</strong> <?php echo $row["atfisica_cm"]; ?></li><br>

                                    <li style="font-weight: bold;">Antecendestes Alérgicos?</li>
                                    <input disabled type="radio" name="alergicos" value="1" <?php if ($row["alergic"] == 1) {echo "checked";} ?>>Sim
                                    <input disabled type="radio" name="alergicos" value="2" style="margin-left:10px;" <?php if ($row["alergic"] == 2) {echo "checked";} ?> >Não
                                    <br>
									<br><li><strong>Observação:</strong> <?php echo $row["alergic_cm"]; ?></li><br>
									
                                    <li style="font-weight: bold;">Diabetes?</li>
                                    <input disabled type="radio" value="1" name="diabetes" <?php if ($row["diabetes"] == 1) {echo "checked";} ?>>Sim
                                    <input disabled style="margin-left:10px;" type="radio" name="diabetes" value="2" <?php if ($row["diabetes"] == 2) {echo "checked";} ?> >Não
                                    <br>
									<br><li><strong>Observação:</strong> <?php echo $row["diabetes_cm"]; ?></li><br>

									
                                </ol>
                            </div>
                        </div>
						
						
						

						
						
						
<?php


// Informa&ccedil;oes da query. No caso, "SELECT * FROM produtos WHERE EXIBIR=1"  

$campos_query = "*";  

$final_query  = "FROM historico WHERE";


// Conta os resultados no total da minha query  

$strCount = "SELECT COUNT(*) AS 'num_registros' FROM historico WHERE cpfpaciente=$cpfg"; 

 $query2    = mysql_query($strCount);  

 $row2      = mysql_fetch_array($query2); 

 $total    = $row2["num_registros"];  



if($total<=0) {      echo "<br>";  

} else {      

$strQuery = "SELECT * FROM historico WHERE cpfpaciente=$cpfg ORDER BY idhistorico DESC";      

$query2    = mysql_query($strQuery);



while($linhas = mysql_fetch_array($query2)) 

{

$id = $linhas['idhistorico'];

$data = $linhas['data'];

$ocorrencia = $linhas['ocorrencia'];

$texto = $linhas['texto'];


?>

<div class="panel panel-primary">
                            <div class="panel-heading">
                                <h3 class="panel-title">Ocorrência: <?php echo $ocorrencia; ?></h3>
                            </div>
                            <div class="panel-body">
                                <div class="form-group">
                                    <label class="control-label" for="exampleInputEmail1">Data</label>
                                    <input readonly class="form-control" name="ocorrenciadata" id="ocorrenciadata" placeholder="" type="text" value="<?php echo $data; ?>">
                                </div>
                                <div class="form-group">
                                    <label class="control-label" for="exampleInputEmail1">Obervações:</label>
                                    
									<?php echo $texto; ?>
                                </div>
                            </div>
</div>
   

<?php }  }; 

?>
												
												
												
												
												
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6" style="margin-top:10px;">
                        <a class="btn btn-block btn-danger" href="dashp.php?cpf=<?php echo "$cpfg"; ?>">Voltar Menu Inicial</a>
                    </div>
					</form>
                </div>
            </div>
        </div>
    

</body></html>