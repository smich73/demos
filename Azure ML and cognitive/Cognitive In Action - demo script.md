# Cognitive Services Vision APIs
Demos of the cognitive services APIs

Takes about 15-20 minutes.

### Pre Reqs
* None

### Screens and apps
* Chrome or Edge

* https://www.microsoft.com/cognitive-services/en-us/computer-vision-api

## COMPUTER VISION
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


## EMOTION 
### Recognize Emotions in Images
1. Go to https://www.microsoft.com/cognitive-services/en-us/emotion-api and scroll to the `Recognize Emotions in Images` section

2. Use the stock photo

3. Upload and show the faces and emotions detected


## Emotion 
### Recognize Emotions in Video
1. Go to https://www.microsoft.com/cognitive-services/en-us/emotion-api and scroll to the `Recognize Emotions in Video` section

2. Play the default video in the portal

## FACE
### Face detection and verification
1. Go to https://www.microsoft.com/cognitive-services/en-us/face-api and scroll to the `Face Detection` section

2. Use stock image and show face detection and verification

3. Show Face Verification, Face Identification, Similar Face Searching, Face Grouping in portal


## Video
1. Go to https://www.microsoft.com/cognitive-services/en-us/video-api

2. Use the built-in videos to show Stabilize shaky videos, Detect and track faces, Detect motion



## SPEECH
### Bing Speech - speech recognition

1.Go to https://www.microsoft.com/cognitive-services/en-us/speech-api

2.Set the language to  English - GB 

3.Use a sample

### Bing Speech - Text to Speech

1.Go to https://www.microsoft.com/cognitive-services/en-us/speech-api and scroll to  Text to Speech 


2.Set language to  English GB  and  'Susan '


3.Copy this text  Two GUID's walk into a bar .... GUID one says "a wine, a beer and a nice glass of champagne".......the barman says "That's a strange order!" ......GUID two says "Ignore him, he's random" 
◦Note punctuations and pauses
◦Also note that it does not recognise  GUID  properly


### Bing Speech - Speaker Recogntiion > identification

1. Use samples to show identification of presidents

## LANGUAGE
### Spell Check API

1.Go to https://www.microsoft.com/cognitive-services/en-us/bing-spell-check-api

2.Show spell and proof (latter less aggressive and adds capitalisation, basic punctuation and other features to aid doc creation)


### Language Understanding

1.Go to https://www.microsoft.com/cognitive-services/en-us/language-understanding-intelligent-service-luis

2.Explain what it is.

### Language Analytics - sentiment

1.Go to https://www.microsoft.com/cognitive-services/en-us/text-analytics-api

2.Use samples to show positive and negative

### MORE USEFUL CASES

## HOW HAPPY

1. This shows we can combine a few of these APIs - sentiment and LUIS
2. Go to http://howhappy.co.uk/
3.  Upload Justin Beiber picture and upload.
4. Who is the happiest? The daughter
5. Who is the saddest or angriest? No surprise there - the dad
6. who is the most surprised? Apparently it is this girl..

## UBER

Play Uber video -  shows facial verification

## BOT Demos

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
4. Run in emualtor using 'show me value of Microsoft' and 'previous one' (shows context state)

### BOTS plus Cognitive

1. Open Skype
2. Show Bing Music bot – uses Bing video cognitive API – type msuic lyrics or band name
3. Caption bot – upload ‘cat on a bench’
4. Murphy Bot – uses LUIS, bing image search, image processing to combine ‘ what if bill gates had a beard?’





