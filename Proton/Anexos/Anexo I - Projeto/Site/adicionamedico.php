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
if(document.paciente.nomemed.value=="")
	{
	alert("O campo Nome é obrigatório!");
	return false;
	}
else
	if(document.paciente.senhamed.value=="")
	{
	alert("O campo Senha é obrigatório!");
	return false;
	}
else
	if(document.paciente.crmmed.value=="")
	{
	alert("O campo CRM é obrigatório!");
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
                        <h1 class="text-center">Cadastro de Profissional
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
                                <form id="paciente" name="paciente" role="form" method="post" action="adicionamedicobanco.php" onsubmit="return validaCampo()">
                                    <div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Nome</label>
                                        <input class="form-control" name="nomemed" id="nomemed" placeholder="" type="text">
                                    </div>
									<div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">Senha</label>
                                        <input class="form-control" name="senhamed" id="senhamed" placeholder="" type="text">
                                    </div>
									<div class="form-group">
                                        <label class="control-label" for="exampleInputEmail1">CRM</label>
                                        <input class="form-control" name="crmmed" id="crmmed" placeholder="" type="number" pattern="[0-9]*" inputmode="numeric">
                                    </div>
                                   
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