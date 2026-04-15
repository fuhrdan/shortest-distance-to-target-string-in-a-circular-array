//*****************************************************************************
//** 2515. Shortest Distance to Target String in a Circular Array   leetcode **
//*****************************************************************************

int closestTarget(char** words, int wordsSize, char* target, int startIndex) {
    int minDist = INT_MAX;

    for (int i = 0; i < wordsSize; i++) {
        if (strcmp(words[i], target) == 0) {
            int forward = (i - startIndex + wordsSize) % wordsSize;
            int backward = (startIndex - i + wordsSize) % wordsSize;
            
            int dist = forward < backward ? forward : backward;
            
            if (dist < minDist) {
                minDist = dist;
            }
        }
    }

    return (minDist == INT_MAX) ? -1 : minDist;
}