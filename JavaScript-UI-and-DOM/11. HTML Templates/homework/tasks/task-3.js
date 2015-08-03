function solve(){
  return function(){
    $.fn.listview = function(data){
        var templateHolder = $(this).attr("data-template"),
            template = $('#' + templateHolder).html(),
            compiled = handlebars.compile(template);

        for (var i = 0; i < data.length; i+=1) {
            this.append(compiled(data[i]));
        }

        return this;
    };
  };
}

module.exports = solve;