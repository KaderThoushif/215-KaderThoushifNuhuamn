function myAdd() {
    var y = parseInt(document.getElementById("Num1").value);
    var z = parseInt(document.getElementById("Num2").value);
    var x = y + z;
    document.getElementById("Add").innerHTML = "Addition of two numbers is "+ x;
  }

  function mySub() {
    var y = parseInt(document.getElementById("Num1").value);
    var z = parseInt(document.getElementById("Num2").value);
    var x = y - z;
    document.getElementById("Sub").innerHTML = "Subtraction of two numbers is " +x;
  }

  function myMul() {
    var y = parseInt(document.getElementById("Num1").value);
    var z = parseInt(document.getElementById("Num2").value);
    var x = y * z;
    document.getElementById("Mul").innerHTML = "Multiplication of two numbers is"+ x;
  }

  function myDiv() {
    var y = parseInt(document.getElementById("Num1").value);
    var z = parseInt(document.getElementById("Num2").value);
    var x = y % z;
    document.getElementById("Div").innerHTML ="Division of two numbers is"+ x;
  }
