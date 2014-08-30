function addElement(id, parentId, html)  {
    var element = document.createElement("div");
    element.setAttribute("id", id);
    element.innerHTML = html;
    document.getElementById(parentId).appendChild(element);
}
function removeElement(id, parentId){
    var element = document.getElementById(id);
    document.getElementById(parentId).removeChild(element);
}

var nextProgId = 0;
parentProgId = "parentProgLang";

function addProgrammingLanguage(){
    nextProgId++;
    progHtml = "<input type=\"text\" name=\"progLang[]\"/>"
        + "<select name=\"level[]\">"
        + "<option value=\"Beginner\">Beginner</option>"
        + "<option value=\"Programmer\">Programmer</option>"
        + "<option value=\"Ninja\">Ninja</option>"
        + "</select>"
        + "<button onclick='javascript:removeElement(\"progLang"
        + nextProgId
        + "\", \""
        + parentProgId
        + "\")'> Remove Language </button><br/>";
    addElement("progLang" + nextProgId,parentProgId,progHtml);
}

var nextLangId = 0;
parentLangId = "parentLang";


function addLanguage(){
    nextLangId++;
    langHtml = "<input type=\"text\" name=\"lang[]\"/>"
        + "<select name=\"comprehension[]\">"
        + "<option value=\"0\" disabled=\"disabled\" selected=\"selected\">- Comprehension -</option>"
        + "<option value=\"Beginner\">Beginner</option>"
        + "<option value=\"Intermediate\">Intermediate</option>"
        + "<option value=\"Advanced\">Advanced</option>"
        + "</select>"
        + "<select name=\"reading[]\">"
        + "<option value=\"0\" disabled=\"disabled\" selected=\"selected\">- Reading -</option>"
        + "<option value=\"Beginner\">Beginner</option>"
        + "<option value=\"Intermediate\">Intermediate</option>"
        + "<option value=\"Advanced\">Advanced</option>"
        + "</select>"
        + "<select name=\"writing[]\">"
        + "<option value=\"0\" disabled=\"disabled\" selected=\"selected\">- Writing -</option>"
        + "<option value=\"Beginner\">Beginner</option>"
        + "<option value=\"Intermediate\">Intermediate</option>"
        + "<option value=\"Advanced\">Advanced</option>"
        + "</select>"
        + "<button onclick='javascript:removeElement(\"lang"
        + nextLangId
        + "\", \""
        + parentLangId
        + "\")'> Remove Language </button><br/>";
    addElement("lang" + nextLangId, parentLangId, langHtml);
}
