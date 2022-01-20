function RadioButton(){
    var getSelectedValue =  document.querySelector('input[name="Gender"]:checked');
    if(getSelectedValue != null){
        document.getElementById("Radio").innerHTML = getSelectedValue.value;
    } 
}