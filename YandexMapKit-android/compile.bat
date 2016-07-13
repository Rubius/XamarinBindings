rem CLEAN
rd /S /Q Bindings\Jars	
rd /S /Q Bindings\lib
rd /S /Q Bindings\bin
rd /S /Q Bindings\obj
rd /S /Q YandexMapTestApp\bin
rd /S /Q YandexMapTestApp\obj
rd /S /Q aar
del yandexmapkit-library.aar
rem exit /b 1


rem PROCESS
git clone https://github.com/yandexmobile/yandexmapkit-android.git

mkdir aar
mkdir aar\jni

robocopy yandexmapkit-android\yandexmapkit-library\libs aar\jni /MIR
del aar\jni\classes.jar
copy yandexmapkit-android\yandexmapkit-library\libs\classes.jar aar\
copy yandexmapkit-android\yandexmapkit-library\AndroidManifest.xml aar\
robocopy yandexmapkit-android\yandexmapkit-library\res aar\res /MIR

C:\Users\DrobinskiyAV\AppData\Local\Android\android-sdk\build-tools\23.0.1\aapt.exe package -v -f -m -S yandexmapkit-android\yandexmapkit-library\res -M yandexmapkit-android\yandexmapkit-library\AndroidManifest.xml -I C:\Users\DrobinskiyAV\AppData\Local\Android\android-sdk\platforms\android-23\android.jar --output-text-symbols aar -J aar

"C:\Program Files\7-Zip\7z.exe" a -tzip yandexmapkit-library.aar .\aar\*



mkdir Bindings\Jars
copy yandexmapkit-library.aar Bindings\Jars\
robocopy yandexmapkit-android\yandexmapkit-library\libs Bindings\lib /MIR
del Bindings\lib\classes.jar


