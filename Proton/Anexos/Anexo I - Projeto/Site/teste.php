<?php

	include 'conectabanco.php';


$query = "select * from paciente where cpf='12345678977'";

$resultado = mysql_query($query);

/*
$row = mysql_fetch_assoc($resultado);
    echo $row["nome"];
	echo "<br>";
    echo $row["idade"];
	echo "<br>";
    echo $row["senha"];
	echo "<br>";


mysql_free_result($resultado);*/

?>