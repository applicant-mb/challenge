
# Instructions
- You will need Visual Studio to complete challenges outlined below. We suggest you utilize one of the community editions provided at https://www.visualstudio.com/downloads/
- Clone this repo to your local machine
- Use it to create a new repo on GitHub under your own account (please don't use GitHub fork to accomplish this)
- Complete the challenge below or provide an alternative representative sample of code or classes that is solely your work product. 
  (If you maintain a github project where you are the sole contributor, please feel free to submit a link and description of what we should review in the repository.)
- Send us an email with a link to your repo and any instructions or details you want to share about key features, performance optimizations or creative problem solving skills that they exemplify.

## Also Energy Code Challenge

### Please review the projects in the Challenge solution and perform the following tasks. Please feel free to be creative and simplify when possible. 

1) Fix the bug causing the existing unit test to fail.

2) Add a PermissionSet class to hold a fixed list of 100 user permissions (i.e. perm1, perm2, ...). 
   The PermissionSet should be able to serialize/deserialize as a byte array.

3) Provide a brief comment for each of the following:

   - Concept or element that was unfamiliar or unexpected
     * I don't often get opportunities to work with byte arrays/encoding in my current role, and despite working constantly with SQL Server, I've never worked with SSDT (which proved difficult for my personal Mac to deal with 😃). Combining those two made parsing the project and what it was doing a unique experience for me. What was unexpected (but definitely a pleasant surprise) was seeing C# 8 being used. My current role requires keeping with version 5, so I'm always happy when I get to use see code using the newer language features I don't get to use yet.

   - Constructive review or recommended improvement
     * It would be nice to see a bit more explanation on the PermissionSet piece. What was being described sounded more like an enum than a class (I am curious if that was the point), and I implemented as such. And given the ease of converting those to byte values, I bypassed the BigBitBlob even though it had listed as one of its use cases sending permissions, and instead just created a method returning IEnumerable\<byte> which could have ToArray() called on it and get wrapped by a BigBitBlob.

   - Opportunity or future enhancement
     * As stated, my day-to-day doesn't usually involve fine tuning bitwise operations, so I'd need to do some research to provide any optimization insight on that front. The one bit I would offer as an opportunity is that I generally prefer simple, but not abbreviated variable names, particulary with member variables. So I'd see renaming some fields as an opportunity, at least as far as in use interfaces allow.
