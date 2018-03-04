$(document).ready(function(){
    
    //get button random variable 
    var buttonNum =  (Math.ceil(Math.random() * 6));	
    //On each button click if button number matches variable display hidden div
    $("#b1").on('click', function(){
        if(buttonNum == 1)
        {
            $("#hiddenDiv").show()
            $("#reset").show()
        }
    })
    $("#b2").on('click', function(){
        if(buttonNum == 2)
        {
            $("#hiddenDiv").show()
            $("#reset").show()
        }
    })
    $("#b3").on('click', function(){
        if(buttonNum == 3)
        {
            $("#hiddenDiv").show()
            $("#reset").show()
        }
    })
    $("#b4").on('click', function(){
        if(buttonNum == 4)
        {
            $("#hiddenDiv").show()
            $("#reset").show()
        }
    })
    $("#b5").on('click', function(){
        if(buttonNum == 5)
        {
            $("#hiddenDiv").show()
            $("#reset").show()
        }
    })
    $("#b6").on('click', function(){
        if(buttonNum == 6)
        {
            $("#hiddenDiv").show()
            $("#reset").show()
        }
    })

    $("#reset").on('click', function(){
        location.reload();
    })

})