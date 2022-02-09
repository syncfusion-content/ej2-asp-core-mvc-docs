var gulp=require("gulp")
var glob=require("glob")
var fs=require("fs")
var shell=require('shelljs')

gulp.task("empty-tab",function(){
    var tabtitle;
    var mdfiles=glob.sync('ej2-asp-core-mvc/**/*.md');
    for(var a=0;a<mdfiles.length;a++){
        var mdcont=fs.readFileSync(mdfiles[a],'utf8');

        tabtitle=mdcont.match(/.+tabtitle="code-snippet.+/g)
        if(tabtitle !==null){
            for(var i=0;i<tabtitle.length;i++){
        var codeSnip=tabtitle[i].match(/"[\s\S]+"/gm).toString().replace(/"/g,"").trim()
        console.log(`${codeSnip} in ${mdfiles[a]}`);
        var sourcefile=codeSnip.split('/');
        sourcefile=caps(sourcefile[sourcefile.length-1])
            mdcont=mdcont.replace(tabtitle[i],`{% highlight c# tabtitle="${sourcefile}" %}\n{% include ${codeSnip} %}`);
    }
    fs.writeFileSync(mdfiles[a],mdcont)
}
}
})
function caps(cnt) {
    return cnt.charAt(0).toUpperCase() + cnt.slice(1);

}