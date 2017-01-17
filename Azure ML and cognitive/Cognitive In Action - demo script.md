# Cognitive Services Vision APIs
Demos of the cognitive services APIs

### Pre Reqs
* howhappy.co.uk
* https://www.bing.com/translator/
* LUIS.ai
* https://qnamaker.ai/
* https://dev.botframework.com/
* Intelligent Kiosk apps
* https://www.microsoft.com/cognitive-services/en-us/
* loancalc open for editing in browser
* Visual Studio with Botdemo 1, botdemo2 and texttospeechbot Open
* Bot emulator

### Screens and apps
* Chrome or Edge

* https://www.microsoft.com/cognitive-services/en-us/computer-vision-api

## VISION: COMPUTER VISION
### Analyse
1. Go to https://www.microsoft.com/cognitive-services/en-us/computer-vision-api and scroll to the `Analyze and Image` section

2. Use coffee cup image, upload and show JSON description, tags, adult, gender, age, categories etc.
  
3. Repeat with a stock portal image showing a face
 

### Recognise Celebs
1. Go to https://www.microsoft.com/cognitive-services/en-us/computer-vision-api and scroll to the `Recognize celebrities` section

2. Explain this is a domain-specific model. Working on more.

3. Ask audience for suggestion for celeb or use 'Satya'

4. Explore JSON


### Analyze video in near real-time
1. Go to https://www.microsoft.com/cognitive-services/en-us/computer-vision-api and scroll to the `Analyze video in near real-time` section

2. Play the beach video


### Read text in images
1. Go to https://www.microsoft.com/cognitive-services/en-us/computer-vision-api and scroll to the `Read text in images` section

2. Use the stock images and show JSON

3. Talk about detecting language option/auto-detect

### Generate Thumbnails
1. Go to https://www.microsoft.com/cognitive-services/en-us/computer-vision-api and scroll to the `Generate a thumbnail` section

2. Use some of the stock portal image

3. Toggle smart cropping on and off


## VISION: EMOTION 
### Recognize Emotions in Images
1. Go to https://www.microsoft.com/cognitive-services/en-us/emotion-api and scroll to the `Recognize Emotions in Images` section

2. Use the stock photo

3. Upload and show the faces and emotions detected


### Recognize Emotions in Video
1. Go to https://www.microsoft.com/cognitive-services/en-us/emotion-api and scroll to the `Recognize Emotions in Video` section

2. Play the default video in the portal


## VISION: FACE
### Face detection and verification
1. Go to https://www.microsoft.com/cognitive-services/en-us/face-api and scroll to the `Face Detection` section

2. Use stock image and show face detection and verification

3. Show Face Verification, Face Identification, Similar Face Searching, Face Grouping in portal


## VISION: Video
1. Go to https://www.microsoft.com/cognitive-services/en-us/video-api

2. Use the built-in videos to show Stabilize shaky videos, Detect and track faces, Detect motion

## VISION: UBER

Play Uber video -  shows facial verification


## SPEECH: Bing Speech
### Bing Speech - speech to text

1.Go to https://www.microsoft.com/cognitive-services/en-us/speech-api

2.Set the language to  English - GB 

3.Use sample 1 or 2

### Bing Speech - Text to Speech

1.Go to https://www.microsoft.com/cognitive-services/en-us/speech-api and scroll to  Text to Speech 


2.Set language to  English GB  and  'Susan '


3.Use sample text file for the customer (note punctuation,pauses)

## SPEECH: Speaker Recognition
### Bing Speech - Presidents

1. Use samples to show identification of presidents (audio 1 sample)


## LANGUAGE
### Spell Check API

1.Go to https://www.microsoft.com/cognitive-services/en-us/bing-spell-check-api

2.Show spell and proof (latter less aggressive and adds capitalisation, basic punctuation and other features to aid doc creation)


### Language Understanding

1.Go to https://www.microsoft.com/cognitive-services/en-us/language-understanding-intelligent-service-luis

2.Explain what it is.Show light demo

### Language Analytics - sentiment

1.Go to https://www.microsoft.com/cognitive-services/en-us/text-analytics-api

2.Use samples to show positive and negative

### Language Analytics - translation

1.Go to https://www.bing.com/translator/

2.Use sample text for customer to translate text from English -> Spanish/German and then also show voice conversion


## KNOWLEDGE AND SEARCH
### Knowledge and Search

1.Talk about it and show samples of search

2.Show QnA maker now if you are not going to show it later with BotStockDemo1

3. Show recommendations example

## HOW HAPPY

1. This shows we can combine a few of these APIs - EMOTION and LUIS
2. Go to http://howhappy.co.uk/
3. Upload Justin Beiber picture and talk about it
4. Who is the happiest? The daughter
5. Who is the saddest or angriest? No surprise there - the dad
6. who is the most surprised? Apparently it is this girl..

## INTELLIGENT KIOSK

1. Automatic face capture: example capturing photos from web camera
It uses the built-in face tracking functionality in Windows 10 to detect when people are nearby and applies a simple 
movement detection heuristic to determine when they are posing for a photo. In the example it also shows the age, 
gender and identification of all the people in each capture. This is recognising me from a trained facial model that is validating matching me with library images

Tech used: Windows 10 Face Tracking; Cognitive Age and gender prediction; Cognitiv Face identification/verification

2. Bing News 
Connecting the Bing News APIs with the Text Analytics APIs to create a visualization of the news based on their sentiment and most common topics

Tech used: Bing News API, Bing AutoSuggestion API, Text Sentiment and Text KeyPhrase Extraction

3. Emotion API Explorer
Playground for Emotion APIs - show smiling, sad etc..

Tech used: Windows 10 Face Tracking; Emotion prediction; Bing Image Search API; Bing AutoSuggestion API

4. Face API 
A playground for the Face APIs used for age and gender prediction, as well as face identification

Tech used: Windows 10 Face Tracking; Age and gender prediction; Face identification; Facial landmarks; Bing Image Search API; Bing AutoSuggestion API

5. Mall KIOSK
An example of a Mall kiosk that makes product recommendations based on the people in front of the camera and analyzes their reaction to it

Tech used: Windows 10 Face Tracking; Age and gender prediction; Realtime sampling of Emotion; Face identification; Windows 10 Speech-To-Text; Text Sentiment Analysis

6. Realtime crowd insights
A realtime workflow for processing frames from a web camera to derive realtime crowd insights such as demographics, emotion and unique face counting

Tech used:  Windows 10 Face Tracking; Realtime sampling; Age, gender and emotion prediction; Face identification; Unique face counting

7. realtime driving monitor
A futuristic scenario where a dashboard camera in a car could be used to monitor the driver and determine when the driver is looking away from the road ahead, sleeping, yawning etc.  
Show looking away and also the audio warning for wake up when falling asleep (toggle on right needs to be set to ON)

Tech used:  Windows 10 Face Tracking; Realtime sampling; Facial Landmarks; Head Pose; Face identification; Unique face tracking; Image Captioning

## SEEING AI

Play SeeingAI video - combines emotion, caption, text analytics, OCR



## BOT Dev Demos

### Simple BOT

1. Show hello world project in Emulator (new> project >bot in c#)

2. Now open BotStockDemo1 from: https://github.com/smich73/demos/tree/master/Bot%20Framework/BotStockDemo1/BotStockDemo1

3. Replace the lines in messagecontroller.cpp with the code in the codesnippet1.txt file or run as-is

4. Show Yahoo class

5. Run in emulator – just enter stock symbol eg. MSFT

6. Show that you cannot use NLP eg. ‘show me stock symbol for MSFT’

7. Show portal at dev.botframework.com and how you can select channels

### BOT plus LUIS

1. Use https://github.com/smich73/demos/tree/master/Bot%20Framework/BotStockDemo2/BotStockDemo2
2. Show LUIS dialog cs file and entry point
3. Show luis.ai stock model
4. Run in emulator using 'show me value of Microsoft' and 'previous one' (shows context state)

## BOT Demos

### BOTS plus Cognitive

1. Open Skype
2. Show Bing Music bot – uses Bing video cognitive API – type music lyrics or band name - eg. Muse
3. Show Bing News bot – uses Bing news API
3. Caption bot – upload ‘cat on a bench’. Also show picture of crowd that illustrates combination of sentiment with captions in response.
4. Murphy Bot – uses LUIS, bing image search, image processing to combine ‘ what if bill gates had a beard?’
5. Show text to speech code sample

### Skyscanner BOT

1. Say 'hi'
2. Say 'Fly to Rome from Gatwick next weekend' or 'Fly to Rome from Gatwick first weekend in March' .Note identified from, to and also provided date for weekend
3. Enter return date eg.  'Dec 4th'
4. returned results - Note the use of carousel/hero cards
5. Can set pro-active price alerts


### EXCEL BOT

1.  Try http://aka.ms/excelbot or https://join.skype.com/bot/b938da29-09bc-4513-9349-85ec239e7886 to add the bot to your Skype (consumer) contacts.
2. Open the excel sheet (one drive for business) - loancalc.xls – using edge or Chrome. Ensure it is opened for editing in the browser
We want to show valuations and calculations changing and so have Excelbot working side-by-side with the Excel sheet.
3. Say ‘hi’
4. Authenticate with one drive for business credentials if required
5. Say 'Look at loancalc'
6. Say 'What is the value in C4'?
7. Say 'What names are in the workbook?' (named ranges)
8. Say 'What is the value of totalloancost?'
9. Say 'Change that to  X'
10. Say 'What are the charts in the workbook?'
11. Say 'Show me chart2'




