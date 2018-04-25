            //saving the text inside local storage
            
            function saveEditsM() {

                //get the editable element
                
                var editElem = document.getElementById("aboutM");

                //get the edited element content
                var userVersion = editElem.innerHTML;

                localStorage.setItem('ChangesM', userVersion);
                //save the content to local storage
                //localStorage.userEdits = userVersion;

}

            function saveEditsC() {
                var editElem = document.getElementById("aboutC");

                //get the edited element content
                var userVersion = editElem.innerHTML;

                localStorage.setItem('ChangesC', userVersion);
}

            function saveEditsJ() {
                var editElem = document.getElementById("aboutJ");

                //get the edited element content
                var userVersion = editElem.innerHTML;

                localStorage.setItem('ChangesJ', userVersion);
            }
            
            //Checking the local storage for edits.
            
            function checkEdits() {

                //find out if the user has previously saved edits
                if(localStorage.userEdits!=null)
                    document.getElementById("aboutM").innerHTML = localStorage.userEdits;
            }