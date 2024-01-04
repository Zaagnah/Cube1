mergeInto(LibraryManager.library, {

  	ShowAdv : function(){
        ysdk.adv.showFullscreenAdv({
          callbacks: {
          onOpen:
            myGameInstance.SendMessage('GameManager', 'SoundOff';
          onClose: function(wasShown) {
            console.log("------------- closed --------------");
            // some action after close
            myGameInstance.SendMessage('GameManager', 'SoundOn';
          },
          onError: function(error) {
            // some action on error
          }
        }
        })
    },

    RateMyGame : function(){
        ysdk.feedback.canReview()
        .then(({ value, reason }) => {
            if (value) {
                ysdk.feedback.requestReview()
                    .then(({ feedbackSent }) => {
                        console.log(feedbackSent);
                    })
            } else {
                console.log(reason)
            }
        })
    },
    GetLang : function () {
        var lang = ysdk.environment.i18n.lang;
        var bufferSize = lengthBytesUTF8(lang) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(lang, buffer, bufferSize);
        return buffer;
    } 
    

  });