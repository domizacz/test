function my_function() { console.log("test") }

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("TutorWeb.Client", "GetCuntentCount")
        .then(result => {
            console.log("count from Javascryp" + result);
        });
}

function dotnetInstanceInvocation(dotnetHelper)
{
    dotnetHelper.invokeMethodAsync("IncrementCount");

}
