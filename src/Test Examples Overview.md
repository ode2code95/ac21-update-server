## Structure
Customer | Product ID (GUID) | Eligibility Tier (GUID [])
Product  | Version ID (GUID) | Fetch Ref (if time)

## Tiers
- Static data in (Mock Db)
- Record Filter
- Record Transformation
- Record Return (IActionResult)

## Test for:
- Record not found
  - Exception during database
- Transposition of filtering criteria

## Good test:
Db exception - Map/Bind on Option
Copy-and-update (new type)

## Bad test
- Data store nested within record filtering
- Try-catch (or worse, unhandled)
- Mutate record, with error swallowing
