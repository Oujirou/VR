for file in *.cs; do
    gsed -i '1s/^/#if !UNITY_EDITOR_OSX\n/gm; $s/$/\n#endif/gm' $file;
done;
