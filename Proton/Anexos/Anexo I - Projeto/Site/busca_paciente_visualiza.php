<html><head>
        <title>ProtOn - Prontuario Online</title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <script type="text/javascript" src="http://cdnjs.cloudflare.com/ajax/libs/jquery/2.0.3/jquery.min.js"></script>
        <script type="text/javascript" src="http://netdna.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
        <link href="http://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet" type="text/css">
        <link href="style.css" rel="stylesheet" type="text/css">
		
				<script type="text/javascript">
function validaCampo()
{
if(document.busca.cpfbusca.value=="")
	{
	alert("O campo CPF é obrigatório!");
	return false;
	}
return true;
}
</script>
    </head>
	
	<body>
	
	
	<div class="navbar navbar-default navbar-static-top"><div class="container">
	<div class="navbar-header"><a class="navbar-brand" href="#"><span>ProtOn</span></a></div>
	<div class="collapse navbar-collapse" id="navbar-ex-collapse"></div></div></div><div class="section"><div class="container"><div class="row"><div class="col-md-12"><div class="panel panel-primary"><div class="panel-heading"><h6 class="panel-title text-center">Buscar Paciente</h6></div><div class="panel-body">
	
	<form role="form" id="busca" name="busca" method="post" action="visualizap.php" onsubmit="return validaCampo()">
	<div class="form-group">
	<label class="control-label" for="exampleInputEmail1">CPF do Paciente</label>
	<input name="cpfbusca" id="cpfbusca" class="form-control" id="exampleInputEmail1" type="number" pattern="[0-9]*" inputmode="numeric"></div>
	<button type="submit" class="btn btn-default">Buscar</button>
	</form>
	
	
	
	
	</div></div></div>
	<div class="col-md-6" style="margin-top:10px;">
                        <a class="btn btn-block btn-danger" href="dashm.php">Voltar</a>
                    </div>
	
	</div></div></div>
	</body></html>