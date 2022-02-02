<html><head>
    <title>ProtOn - Prontuario Online</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script type="text/javascript" src="http://cdnjs.cloudflare.com/ajax/libs/jquery/2.0.3/jquery.min.js"></script>
    <script type="text/javascript" src="http://netdna.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
    <link href="http://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <link href="style.css" rel="stylesheet" type="text/css">
  </head><body>
    <div class="navbar navbar-default navbar-fixed-top">
      <div class="container">
        <div class="navbar-header">

          <a class="navbar-brand"><span>ProtoOn</span></a>
        </div>

      </div>
    </div>
    <div class="section">
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <h1 class="text-center">Login Paciente</h1>
            <form class="form-horizontal" id="loginp" name="loginp" role="form" method="post" action="loginp2.php">
              <div class="form-group">
                <div class="col-sm-2">
                  <label for="inputEmail3" class="control-label">CPF</label>
                </div>
                <div class="col-sm-10">
                  <input type="number" pattern="[0-9]*" inputmode="numeric" class="form-control" id="inputEmail3" placeholder="" name="cpf" id="cpf">
                </div>
              </div>
              <div class="form-group">
                <div class="col-sm-2">
                  <label for="inputPassword3" class="control-label"> Senha</label>
                </div>
                <div class="col-sm-10">
                  <input type="password" class="form-control" id="inputPassword3" placeholder="" name="senha" id="senha">
                </div>
              </div>
              <div class="form-group">
                <div class="col-sm-offset-2 col-sm-10">
                  <input name="entrar" id="entrar" type="submit" class="btn btn-default btn-lg" value="Logar">
                </div>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>


</body></html>