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
                        <h1 class="text-center">Cadastro de Paciente
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
                                <form id="paciente" name="paciente" role="form" method="post" action="cadastrapbanco.php" onsubmit="return validaCampo()">
                                    <div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Nome</label>
                                        <input class="form-control" name="nomepac" id="nomepac" placeholder="" type="text">
                                    </div>
									<div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Senha</label>
                                        <input class="form-control" name="senhapac" id="senhapac" placeholder="" type="text">
                                    </div>
									<div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">CPF</label>
                                        <input class="form-control" name="cpfpac" id="cpfpac" placeholder="" type="number" pattern="[0-9]*" inputmode="numeric">
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Sexo</label>
                                        <input class="form-control" name="sexopac" id="sexopac" placeholder="" type="text">
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Idade</label>
                                        <input class="form-control" name="idadepac" id="idadepac" placeholder="" type="text">
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Data de Nascimento</label>
                                        <input class="form-control" name="datapac" id="datapac" placeholder="" type="text">
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Telefone</label>
                                        <input class="form-control" name="telpac" id="telpac" placeholder="" type="text">
                                    </div>
                                    <div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Celular</label>
                                        <input class="form-control" name="celpac" id="celpac" placeholder="" type="text">
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
                                    <input class="form-control" name="nomece" id="nomece" placeholder="" type="text">
                                </div>
                                <div class="form-group">
                                    <label class="control-label" for="exampleInputEmail1">Telefone</label>
                                    <input class="form-control" name="telce" id="telce" placeholder="" type="text">
                                </div>
                                <div class="form-group">
                                    <label class="control-label" for="exampleInputEmail1">Celular</label>
                                    <input class="form-control" name="celce" id="celce" placeholder="" type="text">
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
                                    <li>Lesões?</li>
                                    <input type="radio" name="lesao" value="1">Sim
                                    <input style="margin-left:10px;" type="radio" name="lesao" value="2" checked>Não
                                    <br>
                                    <input type="text" name="lesaotext" id="lesaotext" value="">
                                    <li>Fumante?</li>
                                    <input type="radio" name="fumante" value="1">Sim
                                    <input style="margin-left:10px;" type="radio" name="fumante" value="2" checked>Não
                                    <br>
                                    <li>Portador de Marcapasso?</li>
                                    <input type="radio" name="marcapasso" value="1">Sim
                                    <input style="margin-left:10px;" type="radio" name="marcapasso" value="2" checked>Não
                                    <br>
                                    <input type="text" name="marcatext" id="marcatext" value="">
                                    <li>Hipertensão?</li>
                                    <input type="radio" name="hipertensao" value="1">Sim
                                    <input type="radio" value="2" style="margin-left:10px;" name="hipertensao" checked>Não
                                    <br>
                                    <input type="text" name="hipertext" id="hipertext" value="">
                                    <li>Epilepsia?</li>
                                    <input type="radio" name="epilepsia" value="1">Sim
                                    <input style="margin-left:10px;" type="radio" name="epilepsia" value="2" checked>Não
                                    <br>
                                    <input type="text" name="epileptext" id="epileptext" value="">
                                    <li>Pratica atividade física?</li>
                                    <input type="radio" name="fisica" value="1">Sim
                                    <input style="margin-left:10px;" type="radio" name="fisica" value="2" checked>Não
                                    <br>
                                    <input type="text" name="fisicatext" id="fisicatext" value="">
                                    <li>Antecendestes Alérgicos?</li>
                                    <input type="radio" name="alergicos" value="1">Sim
                                    <input type="radio" name="alergicos" value="2" style="margin-left:10px;" checked>Não
                                    <br>
                                    <input type="text" name="alergictext" id="alergictext" value="">
                                    <li>Diabetes?</li>
                                    <input type="radio" value="1" name="diabetes">Sim
                                    <input style="margin-left:10px;" type="radio" name="diabetes" value="2" checked>Não
                                    <br>
                                    <input type="text" name="diabetext" id="diabetext" value="">
									
                                </ol>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <input class="btn btn-block btn-success" type="submit" value="Salvar Alterações">
                    </div>
                    <div class="col-md-6" style="margin-top:10px;">
                        <a class="btn btn-block btn-danger" href="dashm.php">Cancelar Alterações</a>
                    </div>
					</form>
                </div>
            </div>
        </div>
    

</body></html>