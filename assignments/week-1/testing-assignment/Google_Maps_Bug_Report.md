# GOOGLE MAPS - BUG REPORT DOCUMENT

##  Project: Google Maps App Testing

##  Tester: Paras Tomar

##  Environment: Mobile Application (Android-based)

##  Testing Type: Manual Testing

#  Bug Summary

* Total Bugs Identified: **5**

#  Bug Details

## BUG_001

**Title:** Offline search fails for major landmark within downloaded region  

**Environment:**  
Android device, Google Maps (latest), Airplane mode ON  

**Preconditions:**  
- Offline map for Jaipur downloaded  
- Landmark (Hawa Mahal) within downloaded area  

**Steps to Reproduce:**  
1. Open Google Maps  
2. Ensure offline map is available  
3. Turn ON airplane mode  
4. Search for “Hawa Mahal”  

**Expected Result:**  
App should return search results using offline data  

**Actual Result:**  
Displays error: “Can’t reach the internet. Check your connection”  

**Severity:** Medium  
**Priority:** High  

## BUG_002

**Title:** Route flickering and unstable rerouting during minor GPS deviation in consecutive turns  

**Environment:**  
Android device, GPS ON, urban area with closely spaced turns  

**Preconditions:**  
- Navigation started with consecutive turns  

**Steps to Reproduce:**  
1. Start navigation  
2. Follow route  
3. Slightly overshoot first turn (~2–5 meters)  
4. Observe route recalculation  

**Expected Result:**  
- Stable navigation  
- No unnecessary rerouting for minor deviation  
- Smooth guidance for next turn  

**Actual Result:**  
- Route flickers between paths  
- Multiple recalculations  
- Delay in next turn instruction  

**Severity:** High  
**Priority:** High  

## BUG_003

**Title:** Generic error message shown instead of offline-specific guidance when searching outside downloaded map  

**Environment:**  
Android device, Offline mode  

**Preconditions:**  
- Offline map downloaded  
- Internet OFF  

**Steps to Reproduce:**  
1. Turn off internet  
2. Search for location outside offline area  

**Expected Result:**  
App should display message like:  
“Location not available in offline maps”  

**Actual Result:**  
Displays generic message:  
“Check your internet connection”  

**Severity:** Low  
**Priority:** Medium  

## BUG_004

**Title:** Navigation behavior inconsistent when GPS is turned off during active navigation  

**Environment:**  
Android device, GPS initially ON  

**Preconditions:**  
- Navigation active  

**Steps to Reproduce:**  
1. Start navigation  
2. Turn OFF GPS  
3. Observe behavior  

**Expected Result:**  
- App should pause navigation  
- Clear message prompting user to enable GPS  

**Actual Result:**  
- Navigation continues inconsistently  
- Delayed or incorrect updates  

**Severity:** High  
**Priority:** High  

## BUG_005

**Title:** Navigation state not reliably restored after app is killed during active navigation  

**Environment:**  
Android device, Google Maps latest  

**Preconditions:**  
- Navigation in progress  

**Steps to Reproduce:**  
1. Start navigation  
2. Kill app from recent apps  
3. Reopen app  

**Expected Result:**  
- Navigation should resume OR  
- User should be prompted to resume previous session  

**Actual Result:**  
- Navigation state lost OR inconsistent restoration  

**Severity:** Medium  
**Priority:** High  


# Notes

- Covers offline functionality, navigation stability, and error handling  
- Focus on real-world usability scenarios  