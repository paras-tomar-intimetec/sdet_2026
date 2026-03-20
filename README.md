# SDET 2026 Training
This repository contains structured assignments for SDET training.

## Structure

## -> Week 1 ->

## -> Git Assignment 

## Topics Covered

- Git basic workflow (add, commit, push)
- Branching and switching
- Merge (fast-forward and 3-way)
- Merge conflicts and resolution
- Git stash usage
- Git cherry-pick
- Git reset and restore
- Remote operations
- Pull Request workflow
- Hotfix Operation
- Git tagging

#  -> Testing Assignment – Demo Web Shop
This repository contains all testing artifacts created as part of **Week-1 Testing Assignment**.

##  Project Overview
- **Application Tested:** Demo Web Shop  
- **Testing Type:** Manual Testing  
- **Tester:** Paras Tomar  
- **Platform:** Web Application (Browser-based)  

##  Test Cases
- Total Test Cases: **30+**
- Covers:
  - Registration
  - Login
  - Product Listing
  - Cart & Checkout
  - Wishlist
  - Filters & Sorting
  - Newsletter
  - UI/UX validations

 File: `Demo_Web_Shop_Test_Cases.xlsx`

##  Bug Report
- Total Bugs Identified: **10+**
- Categories:
  - Functional Bugs
  - Validation Issues
  - UI/UX Issues

📄 File: `Demo_Web_Shop_Bug_Report.md`

Each bug includes:
- Description  
- Steps to Reproduce  
- Expected vs Actual Result  
- Severity & Priority  
- Screenshot Reference  

##  Key Observations
- Weak validation in forms (password, address, product input)
- Inconsistent UI behavior (wishlist, add to cart)
- Missing stock visibility before user action
- Navigation and usability issues

#  Mobile & Security Testing Assignment – Google Maps (Android)

This repository contains all testing artifacts created as part of a **Mobile & Security Testing Assignment** focusing on a real-world application.

##  Project Overview
* **Application Tested:** Google Maps (Android)
* **Testing Type:** Manual + Exploratory Testing
* **Tester:** Paras Tomar
* **Platform:** Mobile Application (Android)
* **Testing Approach:** Black-box testing with focus on real-world scenarios

## Test Cases
* Total Test Cases: **30+**
* Includes:
  * Positive scenarios
  * Negative scenarios
  * Edge cases
  * State transitions (online ↔ offline)
  * Permission changes during runtime
  * App lifecycle scenarios

📂 File: `Google_Maps_Test_Cases.xlsx`

##  Bug Report
* Total Bugs Identified: **5 High-Quality Defects**
* Categories:
  * Functional Issues
  * Navigation Stability Issues
  * Offline Behavior Gaps
  * UX & Error Messaging Issues

📂 File: `Google_Maps_Bug_Report.md`

Each bug includes:
* Description
* Steps to Reproduce
* Expected vs Actual Result
* Severity & Priority
* Real-world impact

##  Security Testing Insights
* Application correctly enforces OS-level permission restrictions in most scenarios
* Session handling relies heavily on platform-level security rather than explicit timeout mechanisms
* Input handling is robust but requires validation for extreme cases
* Sensitive data exposure through UI/notifications needs careful validation

###  OWASP Mapping (Conceptual)
Security test cases were mapped to **OWASP Mobile Top 10** categories:

* M1: Improper Platform Usage
* M2: Insecure Data Storage / Exposure
* M3: Insecure Authentication / Session Management
* M5: Insufficient Input Validation

##  Limitations

- Testing performed without access to backend logs  
- Security testing limited to black-box validation  
- GPS accuracy depends on device/environment conditions  




