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
  </head>
  <body>
    <div class="navbar navbar-default navbar-fixed-top">
      <div class="container">
        <div class="navbar-header">
          <a class="navbar-brand"><span>ProtoOn</span></a>
        </div>
        <div class="collapse navbar-collapse" id="navbar-ex-collapse"></div>
      </div>
    </div>
	<br><br>
    <div class="section">
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <div class="panel panel-primary">
              <div class="panel-heading">
                <h3 class="panel-title">Adicionar Historico Médico</h3>
              </div>
              <div class="panel-body">
                <form form id="pacientehistorico" name="pacientehistorico" role="form" method="post" action="adicionahistoricobanco.php">
                  <div class="form-group">
                    <label class="control-label" for="exampleInputEmail1">CPF</label>
                    <input class="form-control" id="exampleInputEmail1" name="cpfpac" id="cpfpac" placeholder="" type="number" pattern="[0-9]*" inputmode="numeric">
                  </div>
                  <div class="form-group">
                    <label class="control-label" for="exampleInputPassword1">Procedimento</label>
                    <input class="form-control" id="exampleInputPassword1" type="text" name="ocorrencia" id="ocorrencia">
                  </div>
                  <div class="form-group">
                    <label class="control-label" for="exampleInputPassword1">Data</label>
                    <input class="form-control" id="exampleInputPassword1" type="text" name="data" id="data">
                  </div>
                  <div class="form-group">
                    <label class="control-label" for="exampleInputPassword1">Observações</label>
                    <input class="form-control" id="exampleInputPassword1" type="text" name="texto" id="texto">
                  </div>
                
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    
    <div class="section">
      <div class="container">
        <div class="row">
          <div class="col-md-6">
            <input class="btn btn-block btn-success" type="submit" value="Salvar Alterações">
          </div>
          <div class="col-md-6" style="margin-top:10px;">
            <a href="dashm.php" class="btn btn-block btn-danger">Cancelar Alterações</a></form>
          </div>
        </div>
      </div>
    </div>
  

</body></html>