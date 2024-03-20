# SchemasErrorCode

The Netevia error code response to indicate the error of the transaction.

*<span style="color:green">Netevia Error/Response Codes:</span>*
---
___
- <span style="color:red">100</span> : No Error
- <span style="color:red">101</span> : Invalid GMID
- <span style="color:red">102</span> : Invalid GTID
- <span style="color:red">103</span> : Invalid GMPW
- <span style="color:red">104</span> : Invalid GTRC
- <span style="color:red">105</span> : Invalid Card Token
- <span style="color:red">106</span> : Invalid Database
- <span style="color:red">107</span> : Processor does not support the card type
- <span style="color:red">108</span> : Processor module not loaded
- <span style="color:red">109</span> : Invalid amount
- <span style="color:red">110</span> : Void amount exceeds original authorized amount
- <span style="color:red">111</span> : Offline transaction can only be used for Credit Card Sale / EBT Food Stamp Sale
- <span style="color:red">112</span> : Credit / EBT Food Stamp card with cashback is not allowed
- <span style="color:red">113</span> : Addtip must be based on Auth/Sale transactions
- <span style="color:red">114</span> : Finalize must be based on Auth transactions
- <span style="color:red">115</span> : Original transaction has already been voided
- <span style="color:red">116</span> : Offline transaction must supply AuthCode
- <span style="color:red">117</span> : Engine process timed out
- <span style="color:red">118</span> : Proxy process timed out
- <span style="color:red">119</span> : PDC process timed out
- <span style="color:red">120</span> : Processor process timed out
- <span style="color:red">121</span> : Failed to delete the card token info
- <span style="color:red">122</span> : Failed to update the card token info
- <span style="color:red">123</span> : Failed to create the card token info
- <span style="color:red">124</span> : Processor not support the transaction type
- <span style="color:red">125</span> : Transaction type empty
- <span style="color:red">126</span> : Card type empty
- <span style="color:red">127</span> : NeedSwipeCard empty
- <span style="color:red">128</span> : EntryMode empty
- <span style="color:red">129</span> : CardToken empty
- <span style="color:red">130</span> : GTRC empty
- <span style="color:red">131</span> : SourceTraceNum empty
- <span style="color:red">132</span> : CardType empty
- <span style="color:red">133</span> : Card number invalid
- <span style="color:red">134</span> : Card date expired
- <span style="color:red">135</span> : Invalid Track1
- <span style="color:red">136</span> : Invalid Track2
- <span style="color:red">137</span> : AVS Verification Failed
- <span style="color:red">138</span> : Bad CVV or Exp Date
- <span style="color:red">139</span> : ZIP Verification Failed
- <span style="color:red">140</span> : PIN empty.
- <span style="color:red">141</span> : KSN empty
- <span style="color:red">142</span> : Card data is incomplete
- <span style="color:red">143</span> : EntryMode not support this card type
- <span style="color:red">144</span> : EntryMode not support this transaction type
- <span style="color:red">145</span> : Store&Forward mode not support this transaction type
- <span style="color:red">146</span> : Duplicate transaction.
- <span style="color:red">147</span> : Decline.(e.g., in case of Partial Approval and merchant does not support it)
- <span style="color:red">149</span> : PinPad busy, please wait for the current transaction to finish and try again.
- <span style="color:red">150</span> : Failed to connect to pin pad.
- <span style="color:red">151</span> : User/Operator cancel
- <span style="color:red">152</span> : Swipe card time out
- <span style="color:red">153</span> : PinPad unavailable
- <span style="color:red">154</span> : Failed to read card data
- <span style="color:red">155</span> : PinPad declined
- <span style="color:red">156</span> : PinPad invalid serial number
- <span style="color:red">157</span> : PinPad serial number registrationFailed
- <span style="color:red">158</span> : PinPadSerialNumberRegistrationFailed, Pin pad already registered with another GMID/GTID.
- <span style="color:red">159</span> : PinPad Service not suport, please connect 911Software e-mail: dev.cn@911software.com, Thank you.
- <span style="color:red">160</span> : Payment Gateway Network Error
- <span style="color:red">161</span> : Terminal Serial Number Unregistration failed.
- <span style="color:red">162</span> : No Terminal Serial Number registered for TID.
- <span style="color:red">163</span> : Merchant No SetUp
- <span style="color:red">170</span> : Please check PDC config have been enabled your card type.
- <span style="color:red">175</span> : Invalid Message Index
- <span style="color:red">176</span> : Invalid Message Length
- <span style="color:red">177</span> : Invalid Image ID
- <span style="color:red">178</span> : Invalid Image Data
- <span style="color:red">179</span> : The type of terminal not support this function
- <span style="color:red">180</span> : Invalid Card Date
- <span style="color:red">181</span> : Invalid Transaction
- <span style="color:red">182</span> : Invalid InvoiceNum
- <span style="color:red">183</span> : RushMode not support check duplicate
- <span style="color:red">184</span> : RushMode not support EMV
- <span style="color:red">190</span> : System batch invalid, please connect 911Software e-mail: dev.cn@911software.com, Thank you.
- <span style="color:red">191</span> : Batch is processing, please try later.
- <span style="color:red">201</span> : Query database error.
- <span style="color:red">202</span> : No record found.
- <span style="color:red">203</span> : Multiple records found.
- <span style="color:red">204</span> : Processor network invalid
- <span style="color:red">210</span> : Please refer device error code
- <span style="color:red">999</span> : Undefined error

*<span style="color:green">Netevia Batch Operation Error/Response Codes:</span>*
---
___
- <span style="color:red">0NB</span> : No Finalized Transactions to Batch
- <span style="color:red">0GB</span> : Good Batch
- <span style="color:red">0DB</span> : Duplicate Batch
- <span style="color:red">0RB</span> : Rejected Batch
- <span style="color:red">0EB</span> : Batch Failed on Processor Host

*<span style="color:green">Processor Specific Error/Response Codes:</span>*
---
___
- <span style="color:red">000</span> : Approved and completed
- <span style="color:red">001</span> : Refer to issuer
- <span style="color:red">002</span> : Refer to issuer-Special condition
- <span style="color:red">003</span> : Invalid Merchant ID
- <span style="color:red">004</span> : Pick up card (no fraud)
- <span style="color:red">005</span> : Do not honor
- <span style="color:red">006</span> : General error
- <span style="color:red">007</span> : Pick up card, special condition (fraud account)
- <span style="color:red">008</span> : Honor Mastercard with ID
- <span style="color:red">010</span> : Partial approval for the authorized amount returned in Group III version 022
- <span style="color:red">011</span> : VIP approval
- <span style="color:red">012</span> : Invalid transaction
- <span style="color:red">013</span> : Invalid amount
- <span style="color:red">014</span> : Invalid card number
- <span style="color:red">015</span> : No such issuer
- <span style="color:red">019</span> : Re-enter transaction
- <span style="color:red">021</span> : Unable to back out transaction
- <span style="color:red">028</span> : File is temporarily unavailable
- <span style="color:red">034</span> : Mastercard use only, Transaction Cancelled; Fraud Concern (Used in reversal requests only)
- <span style="color:red">039</span> : No credit account
- <span style="color:red">041</span> : Lost card, pick up (fraud account)
- <span style="color:red">043</span> : Stolen card, pick up (fraud account)
- <span style="color:red">051</span> : Insufficient funds
- <span style="color:red">052</span> : No checking account
- <span style="color:red">053</span> : No savings account
- <span style="color:red">054</span> : Expired card
- <span style="color:red">055</span> : Incorrect PIN
- <span style="color:red">057</span> : Transaction not permitted-Card
- <span style="color:red">058</span> : Transaction not permitted-Terminal
- <span style="color:red">059</span> : Transaction not permitted-Merchant
- <span style="color:red">061</span> : Exceeds withdrawal limit
- <span style="color:red">062</span> : Invalid service code, restricted
- <span style="color:red">063</span> : Security violation
- <span style="color:red">065</span> : Activity limit exceeded
- <span style="color:red">075</span> : PIN tried exceeded
- <span style="color:red">076</span> : Unable to locate, no match
- <span style="color:red">077</span> : Inconsistant data, reversed, or repeat
- <span style="color:red">078</span> : No account
- <span style="color:red">079</span> : Already reversed at switch
- <span style="color:red">080</span> : No Financial impact (used in reversal responses to declined originals).
- <span style="color:red">081</span> : Cryptographic error
- <span style="color:red">082</span> : CVV data is not correct
- <span style="color:red">083</span> : Cannot verify PIN
- <span style="color:red">085</span> : No reason to decline
- <span style="color:red">086</span> : Cannot verify PIN
- <span style="color:red">091</span> : Issuer or switch is unavailable
- <span style="color:red">092</span> : Destination not found
- <span style="color:red">093</span> : Violation, cannot complete
- <span style="color:red">094</span> : Unable to locate, no match
- <span style="color:red">096</span> : System malfunction
- <span style="color:red">0A1</span> : POS device authentication successful
- <span style="color:red">0A2</span> : POS device authentication not successful
- <span style="color:red">0A3</span> : POS device deactivation successful
- <span style="color:red">0B1</span> : Surcharge amount not permitted on debit cards or EBT food stamps
- <span style="color:red">0B2</span> : Surcharge amount not supported by debit network issuer
- <span style="color:red">0CV</span> : Card Type Verification Error
- <span style="color:red">0D3</span> : Transaction failure due to missing or invalid 3D-Secure cryptogram
- <span style="color:red">0E1</span> : Encryption is not configured
- <span style="color:red">0E2</span> : Terminal is not authenticated
- <span style="color:red">0E3</span> : Data could not be decrypted
- <span style="color:red">0EA</span> : Verification error
- <span style="color:red">0EB</span> : Verification error
- <span style="color:red">0EC</span> : Verification error
- <span style="color:red">0HV</span> : Hierarchy Verification Error
- <span style="color:red">0K0</span> : Token request was processed
- <span style="color:red">0K1</span> : Tokenization is not configured
- <span style="color:red">0K2</span> : Terminal is not authenticated
- <span style="color:red">0K3</span> : Data could not be de-tokenized
- <span style="color:red">0M0</span> : Mastercard: Canada region-issued Domestic Debit Transaction not allowed
- <span style="color:red">0N3</span> : Cash back service not available
- <span style="color:red">0N4</span> : Exceeds issuer withdrawal limit
- <span style="color:red">0N7</span> : CVV2 Value supplied is invalid
- <span style="color:red">0R0</span> : Customer requested stop of specific recurring payment
- <span style="color:red">0R1</span> : Customer requested stop of all recurring payments from specific merchant
- <span style="color:red">0T0</span> : First check is OK and has been converted
- <span style="color:red">0T1</span> : Check is OK but cannot be converted This is a declined transaction
- <span style="color:red">0T2</span> : Invalid ABA number, not an ACH participant
- <span style="color:red">0T3</span> : Amount greater than the limit
- <span style="color:red">0T4</span> : Unpaid items, failed negative file check
- <span style="color:red">0T5</span> : Duplicate check number
- <span style="color:red">0T6</span> : MICR error
- <span style="color:red">0T7</span> : Too many checks (over merchant or bank limit)
- <span style="color:red">0V1</span> : Daily threshold exceeded

*<span style="color:green">Givex Specific Error/Response Codes:</span>*
---
___
- <span style="color:red">  001  </span> :   Invalid user ID/pswd
- <span style="color:red">  002  </span> :   Cert not exist
- <span style="color:red">  003  </span> :   Cert invalid
- <span style="color:red">  004  </span> :   Validation wrong
- <span style="color:red">  005  </span> :   Certificate closed
- <span style="color:red">  006  </span> :   Certificate expired
- <span style="color:red">  007  </span> :   Unused
- <span style="color:red">  008  </span> :   Cert already active on YYYY-MM-DD HH:MM:SS
- <span style="color:red">  009  </span> :   ERR bal=$99.99 (with actual balance)
- <span style="color:red">  010  </span> :   Invalid amt < min
- <span style="color:red">  011  </span> :   Invalid amt > max
- <span style="color:red">  012  </span> :   Invalid amt
- <span style="color:red">  013  </span> :   Incorrect amt
- <span style="color:red">  014  </span> :   Trans invalid
- <span style="color:red">  015  </span> :   Trans too old
- <span style="color:red">  016  </span> :   Cancel not allowed
- <span style="color:red">  017  </span> :   Invalid operator
- <span style="color:red">  018  </span> :   Serial number not supplied
- <span style="color:red">  019  </span> :   Operation not permitted
- <span style="color:red">  020  </span> :   No transactions meeting specified criteria
- <span style="color:red">  021  </span> :   No report currently started
- <span style="color:red">  022  </span> :   Invalid points
- <span style="color:red">  023  </span> :   Invalid operator
- <span style="color:red">  024  </span> :   Invalid report
- <span style="color:red">  025  </span> :   Invalid cashout
- <span style="color:red">  026  </span> :   Terminal already registered
- <span style="color:red">  027  </span> :   Certificate on hold
- <span style="color:red">  028  </span> :   Certificate cancelled
- <span style="color:red">  029  </span> :   Certificate cancelled for fraud
- <span style="color:red">  030  </span> :   Service code is not valid
- <span style="color:red">  031  </span> :   Certificate is not registered as loyalty program member
- <span style="color:red">  032  </span> :   Certificate has invalid tier_id
- <span style="color:red">  033  </span> :   Promo code is not valid
- <span style="color:red">  034  </span> :   Base points calculation formula is not defined
- <span style="color:red">  035  </span> :   Units quantity is not valid
- <span style="color:red">  036  </span> :   Customer does not qualify for this promo code
- <span style="color:red">  037  </span> :   Promo code points calculation formula is not defined
- <span style="color:red">  038  </span> :   Certificate can only be used after YYYY-MM-DD
- <span style="color:red">  039  </span> :   Invalid terminal ID/pswd
- <span style="color:red">  040  </span> :   Certificate is not active
- <span style="color:red">  041  </span> :   Invalid Security Code
- <span style="color:red">  042  </span> :   Cannot transfer to same card
- <span style="color:red">  043  </span> :   Promo code not active
- <span style="color:red">  044  </span> :   System not set up correctly
- <span style="color:red">  045  </span> :   Balance cannot be transferred
- <span style="color:red">  046  </span> :   Currency conversion failed
- <span style="color:red">  047  </span> :   Currency conversion not allowed
- <span style="color:red">  048  </span> :   Post-Auth references invalid Pre-Auth
- <span style="color:red">  049  </span> :   Phone number is not unique
- <span style="color:red">  050  </span> :   Amt exceeds bal limit
- <span style="color:red">  051  </span> :   Closed on MM/DD HH:MM
- <span style="color:red">  052  </span> :   Invalid selection
- <span style="color:red">  053  </span> :   Form entry has been terminated
- <span style="color:red">  054  </span> :   Terminal not registered
- <span style="color:red">  055  </span> :   Date is invalid
- <span style="color:red">  056  </span> :   Keyed entry not permitted for operator
- <span style="color:red">  057  </span> :   Declined: Activated at Store Store ABC.
- <span style="color:red">  058  </span> :   Terminal is not configured properly.
- <span style="color:red">  059  </span> :   Invalid SKU
- <span style="color:red">  060  </span> :   Invalid reward
- <span style="color:red">  061  </span> :   Self-excluded
- <span style="color:red">  062  </span> :   Cert already registered
- <span style="color:red">  063  </span> :   Cert expired. Bal=$99.99
- <span style="color:red">  064  </span> :   Maximum points adjustment amount exceeded
- <span style="color:red">  065  </span> :   Maximum points balance exceeded
- <span style="color:red">  066  </span> :   Referral already processed
- <span style="color:red">  067  </span> :   The member is already enrolled
- <span style="color:red">  068  </span> :   Self referral not allowed
- <span style="color:red">  069  </span> :   Existing customer can not be referred
- <span style="color:red">  070  </span> :   Declined: Activated at Store Store ABC.
- <span style="color:red">  071  </span> :   Ticket does not exist
- <span style="color:red">  072  </span> :   Ticket invalid
- <span style="color:red">  073  </span> :   Ticket expired
- <span style="color:red">  074  </span> :   Ticket redeemed
- <span style="color:red">  075  </span> :   Ticket already activated
- <span style="color:red">  076  </span> :   ERR bal=$99.99
- <span style="color:red">  077  </span> :   Ticket on hold
- <span style="color:red">  078  </span> :   Ticket cancelled
- <span style="color:red">  079  </span> :   Ticket cancelled for fraud
- <span style="color:red">  080  </span> :   Ticket can be used after this date only: YYYY-MM-DD.
- <span style="color:red">  081  </span> :   Ticket not active
- <span style="color:red">  082  </span> :   Ticket already registered
- <span style="color:red">  083  </span> :   Ticket initial value not active
- <span style="color:red">  084  </span> :   Not permitted at this terminal
- <span style="color:red">  085  </span> :   Daily limit exceeded
- <span style="color:red">  086  </span> :   Weekly limit exceeded
- <span style="color:red">  087  </span> :   Already reversed
- <span style="color:red">  088  </span> :   Package not exist
- <span style="color:red">  089  </span> :   Package issuance not allowed
- <span style="color:red">  090  </span> :   Invalid quantity
- <span style="color:red">  091  </span> :   Invalid item list for custom issuance
- <span style="color:red">  092  </span> :   Insufficient item balance
- <span style="color:red">  093  </span> :   Item not exist
- <span style="color:red">  094  </span> :   No balance to adjust
- <span style="color:red">  095  </span> :   Invalid item/package code
- <span style="color:red">  096  </span> :   Amount cannot be split evenly
- <span style="color:red">  097  </span> :   Card Pack Number does not exist
- <span style="color:red">  098  </span> :   Loyalty card required for this transaction
- <span style="color:red">  099  </span> :   Package redemption not allowed
- <span style="color:red">  100  </span> :   User ID already registered
- <span style="color:red">  101  </span> :   Coupon Already Redeemed
- <span style="color:red">  102  </span> :   Amount is greater than the max balance
- <span style="color:red">  103  </span> :   Same ticket balance transfer not allowed
- <span style="color:red">  104  </span> :   Performance does not match
- <span style="color:red">  105  </span> :   Ticket has already replaced another ticket
- <span style="color:red">  106  </span> :   Coupon not associated to Member Card
- <span style="color:red">  107  </span> :   Coupon not active
- <span style="color:red">  108  </span> :   Coupon expired
- <span style="color:red">  109  </span> :   Coupon does not exist
- <span style="color:red">  110  </span> :   Duplicate Email Address (Account Registration/Update)
- <span style="color:red">  111  </span> :   Duplicate SMS Address (Account Registration/Update)
- <span style="color:red">  112  </span> :   Duplicate Email & SMS Address (Account Registration/Update)
- <span style="color:red">  113  </span> :   No more card to allocate (Register from a pool of cards)
- <span style="color:red">  114  </span> :   Cert must be registered to a CWS account before it can be used
- <span style="color:red">  115  </span> :   Invalid Email address
- <span style="color:red">  116  </span> :   Invalid Channel
- <span style="color:red">  117  </span> :   Cannot be redeemed at this time
- <span style="color:red">  118  </span> :   Invalid number of stores
- <span style="color:red">  119  </span> :   Invalid search distance
- <span style="color:red">  120  </span> :   Invalid amenities
- <span style="color:red">  121  </span> :   Invalid longitude/latitude location
- <span style="color:red">  122  </span> :   Invalid search criteria
- <span style="color:red">  123  </span> :   Invalid performance reference
- <span style="color:red">  124  </span> :   Invalid performance description
- <span style="color:red">  125  </span> :   Invalid ticket barcode
- <span style="color:red">  126  </span> :   Invalid seat
- <span style="color:red">  127  </span> :   Invalid section
- <span style="color:red">  128  </span> :   Invalid row
- <span style="color:red">  129  </span> :   Invalid status
- <span style="color:red">  130  </span> :   Invalid initial ticket value code
- <span style="color:red">  131  </span> :   New patron does not match existing patron for ticket
- <span style="color:red">  132  </span> :   Ticket could not be imported due to a setup issue
- <span style="color:red">  133  </span> :   Invalid pocket
- <span style="color:red">  134  </span> :   No SKU discount found.
- <span style="color:red">  135  </span> :   Limit for registered loyalty cards has been reached
- <span style="color:red">  136  </span> :   Exchange rate updating failed
- <span style="color:red">  137  </span> :   Maximum points per day exceeded
- <span style="color:red">  138  </span> :   Birth date is not old enough
- <span style="color:red">  139  </span> :   Failed to create Mapped Card Group detail
- <span style="color:red">  140  </span> :   Card ID is not unique
- <span style="color:red">  141  </span> :   Amount exceeds redeemable balance $99.99 (with actual balance)
- <span style="color:red">  142  </span> :   Package adjustment not allowed
- <span style="color:red">  143  </span> :   Package adjustment not allowed
- <span style="color:red">  144  </span> :   Primary certificate is not active
- <span style="color:red">  145  </span> :   Units must be greater than 99 (with actual min units)
- <span style="color:red">  146  </span> :   Units must be greater than 99 and less than 9999 (with actual min/max units)
- <span style="color:red">  147  </span> :   Can not transfer, there are pending pre-auth transactions
- <span style="color:red">  148  </span> :   Customer login required
- <span style="color:red">  149  </span> :   Customer Password required
- <span style="color:red">  150  </span> :   Invalid customer login/password
- <span style="color:red">  151  </span> :   Guest Info is not provided
- <span style="color:red">  152  </span> :   Amount is less than threshold
- <span style="color:red">  153  </span> :   Units quantity is less than threshold
- <span style="color:red">  154  </span> :   Amount and Units quantity are less than thresholds
- <span style="color:red">  155  </span> :   Not redeemable at this location
- <span style="color:red">  156  </span> :   The phone number entered has already been used for an existing registered user. Please provide a different number.
- <span style="color:red">  157  </span> :   Customer is not provided
- <span style="color:red">  158  </span> :   Customer does not exist
- <span style="color:red">  159  </span> :   Customer address information not found
- <span style="color:red">  162  </span> :   Customer information is invalid
- <span style="color:red">  163  </span> :   Customer is inactive
- <span style="color:red">  166  </span> :   Error updating customer record
- <span style="color:red">  167  </span> :   Error inserting customer record
- <span style="color:red">  168  </span> :   Address type already exists for customer
- <span style="color:red">  169  </span> :   Mandatory field missing
- <span style="color:red">  170  </span> :   Error inserting customer address record
- <span style="color:red">  171  </span> :   Contact type already exists for customer
- <span style="color:red">  172  </span> :   Error inserting customer contact record
- <span style="color:red">  173  </span> :   Billing Address information for customer not found
- <span style="color:red">  174  </span> :   Could not get info for increment transaction
- <span style="color:red">  176  </span> :   Could not get merchant info
- <span style="color:red">  177  </span> :   Increment transaction failed
- <span style="color:red">  178  </span> :   Card number already registered for automated card reload
- <span style="color:red">  179  </span> :   Error inserting automated reload record
- <span style="color:red">  182  </span> :   Customer already exists
- <span style="color:red">  184  </span> :   Password is invalid
- <span style="color:red">  185  </span> :   No card reload exists for customer
- <span style="color:red">  186  </span> :   Error updating customer contact record
- <span style="color:red">  187  </span> :   Error updating customer address record
- <span style="color:red">  188  </span> :   Error updating customer card reload record
- <span style="color:red">  189  </span> :   No transaction info found
- <span style="color:red">  192  </span> :   Card number already registered for CLP.
- <span style="color:red">  193  </span> :   Error inserting CLP record.
- <span style="color:red">  194  </span> :   Could not get certificate for increment transaction
- <span style="color:red">  195  </span> :   Error updating SMS Verification record
- <span style="color:red">  196  </span> :   The phone number entered has already been used for an existing registered user. Please provide a different number.
- <span style="color:red">  197  </span> :   No tiers found for merchant
- <span style="color:red">  198  </span> :   No member types found for merchant
- <span style="color:red">  199  </span> :   Payment information invalid
- <span style="color:red">  200  </span> :   Invalid Government Identification
- <span style="color:red">  201  </span> :   Merchant Credit (activation) transaction failed
- <span style="color:red">  202  </span> :   Card is not registered to this customer
- <span style="color:red">  203  </span> :   Duplicate reference found in last 24 hours.
- <span style="color:red">  204  </span> :   Patron Card is not unique
- <span style="color:red">  205  </span> :   Invalid Day of Week
- <span style="color:red">  206  </span> :   Invalid Coupon Redeem value
- <span style="color:red">  207  </span> :   No rewards found
- <span style="color:red">  208  </span> :   Insufficient points balance
- <span style="color:red">  209  </span> :   Free reward issuance failed
- <span style="color:red">  210  </span> :   The mobile phone number entered has already been used for an existing registered user. Please provide a different number.
- <span style="color:red">  211  </span> :   Invalid mapping card group
- <span style="color:red">  212  </span> :   From ticket invalid
- <span style="color:red">  213  </span> :   To ticket invalid
- <span style="color:red">  214  </span> :   Full account card cannot be merged
- <span style="color:red">  215  </span> :   No survey found
- <span style="color:red">  216  </span> :   Question ID invalid
- <span style="color:red">  217  </span> :   Answer ID invalid
- <span style="color:red">  218  </span> :   Required answer missing
- <span style="color:red">  219  </span> :   Maximum number of answers exceeded
- <span style="color:red">  220  </span> :   Order Generation failed
- <span style="color:red">  221  </span> :   Invalid Order
- <span style="color:red">  222  </span> :   Order Number has expired
- <span style="color:red">  223  </span> :   Two of optional fields must be provided
- <span style="color:red">  224  </span> :   Multiple customers found
- <span style="color:red">  225  </span> :   Extend free reward failed
- <span style="color:red">  226  </span> :   Loyalty Name is too short
- <span style="color:red">  227  </span> :   Loyalty Name has digits only
- <span style="color:red">  228  </span> :   Multiple records found for requested value. Please refine your search.
- <span style="color:red">  231  </span> :   Verification failed
- <span style="color:red">  232  </span> :   The PIN must be 4 digits in length
- <span style="color:red">  233  </span> :   The PIN can only contain digits
- <span style="color:red">  234  </span> :   Member has no email address
- <span style="color:red">  235  </span> :   Member has no mobile number
- <span style="color:red">  236  </span> :   Invalid Loyalty Name
- <span style="color:red">  237  </span> :   Duplicate Loyalty Name
- <span style="color:red">  238  </span> :   Coupon Promotions not enabled for store
- <span style="color:red">  239  </span> :   No Coupon Issued
- <span style="color:red">  240  </span> :   Amount Spent is less than minimum required
- <span style="color:red">  241  </span> :   Cert can not be reactivated
- <span style="color:red">  242  </span> :   Cert is not expired
- <span style="color:red">  243  </span> :   Cannot process the transaction, only one card can be used per transaction.
- <span style="color:red">  244  </span> :   Minimum amount to be spent is 99.99
- <span style="color:red">  245  </span> :   Invalid Action Type for holding up or restoring or canceling for fraud or canceling card
- <span style="color:red">  246  </span> :   Card can not be restored
- <span style="color:red">  247  </span> :   Transaction already cancelled
- <span style="color:red">  248  </span> :   Duplicate Customer Login
- <span style="color:red">  249  </span> :   Token Expired
- <span style="color:red">  250  </span> :   Reward already redeemed
- <span style="color:red">  251  </span> :   Hold for the certificate is not allowed
- <span style="color:red">  252  </span> :   Cancel for the certificate is not allowed
- <span style="color:red">  253  </span> :   Fraud for the certificate is not allowed
- <span style="color:red">  254  </span> :   Certificate on hold. Bal=$99.99
- <span style="color:red">  255  </span> :   Invalid input for Customer ID/Cardnumber flag
- <span style="color:red">  256  </span> :   Invalid list of customer ids or card numbers
- <span style="color:red">  257  </span> :   No customer(s) found
- <span style="color:red">  258  </span> :   No card(s) found
- <span style="color:red">  259  </span> :   Card has some money value
- <span style="color:red">  260  </span> :   Address is required
- <span style="color:red">  261  </span> :   City is required
- <span style="color:red">  262  </span> :   Email address is required
- <span style="color:red">  263  </span> :   First name is required
- <span style="color:red">  264  </span> :   Gender is required
- <span style="color:red">  265  </span> :   Last name is required
- <span style="color:red">  266  </span> :   Phone number is required
- <span style="color:red">  267  </span> :   Province is required
- <span style="color:red">  268  </span> :   Postal code is required
- <span style="color:red">  269  </span> :   Shipping Address Info is needed.
- <span style="color:red">  270  </span> :   Country is not valid
- <span style="color:red">  271  </span> :   Date Start to get card history is not valid: YYYY-MM-DD
- <span style="color:red">  272  </span> :   Date End to get card history is not valid: YYYY-MM-DD
- <span style="color:red">  273  </span> :   Discount is not valid
- <span style="color:red">  274  </span> :   Email address is not valid
- <span style="color:red">  275  </span> :   Postal/ZIP code is not valid
- <span style="color:red">  276  </span> :   Province is not valid
- <span style="color:red">  277  </span> :   Title is not valid
- <span style="color:red">  278  </span> :   Ecert order info not enough
- <span style="color:red">  279  </span> :   Ecert order detail info not enough
- <span style="color:red">  280  </span> :   Gift card order info not enough
- <span style="color:red">  281  </span> :   Gift card order detail info not enough
- <span style="color:red">  282  </span> :   Order cannot be cancelled
- <span style="color:red">  283  </span> :   Invalid History Type
- <span style="color:red">  284  </span> :   ISO-Serial or Givex Number fields must be filled in.
- <span style="color:red">  285  </span> :   Failed to get cert balance for certificate
- <span style="color:red">  286  </span> :   CWS Address is required
- <span style="color:red">  287  </span> :   CWS Address City is required
- <span style="color:red">  288  </span> :   CWS Address Country is required
- <span style="color:red">  289  </span> :   CWS Address ZIP/Postal Code is required
- <span style="color:red">  290  </span> :   CWS Order Ecert Total is required
- <span style="color:red">  291  </span> :   CWS Order Total is required
- <span style="color:red">  292  </span> :   Reason for CWS Order cancellation is required
- <span style="color:red">  293  </span> :   CWS Item was not found
- <span style="color:red">  294  </span> :   CWS Order creation failed
- <span style="color:red">  295  </span> :   CWS Order FF Shipping Type was not found
- <span style="color:red">  296  </span> :   CWS Order ID is not found
- <span style="color:red">  297  </span> :   No CWS Order Card faces found
- <span style="color:red">  298  </span> :   CWS Address ZIP/Postal Code is not valid
- <span style="color:red">  299  </span> :   CWS Ecert Order Receiving Email is required
- <span style="color:red">  300  </span> :   CWS Ecert Order Total is not valid
- <span style="color:red">  302  </span> :   CWS Entry quantity is not valid
- <span style="color:red">  303  </span> :   CWS Order Total is not valid
- <span style="color:red">  304  </span> :   CWS Order ID is invalid
- <span style="color:red">  305  </span> :   CWS Order Confirmation Email is not valid
- <span style="color:red">  306  </span> :   CWS Ecert Order size is over limit
- <span style="color:red">  307  </span> :   CWS Order Total does not match to the calculated one
- <span style="color:red">  308  </span> :   CWS Ecert Order delivery date in invalid format.
- <span style="color:red">  309  </span> :   CWS Ecert Order delivery date cannot be in the past.
- <span style="color:red">  310  </span> :   CWS Ecert Order Expiry Date is not valid
- <span style="color:red">  311  </span> :   CWS Ecert Order Expiry Date is not valid, for a system-generated date
- <span style="color:red">  312  </span> :   CWS Ecert Order expiry date cannot be on same date or earlier than delivery date, for a system-generated date.
- <span style="color:red">  313  </span> :   CWS Ecert Order expiry date cannot be on same date or earlier than delivery date.
- <span style="color:red">  314  </span> :   CWS Ecert Order Receiving Email is not valid
- <span style="color:red">  315  </span> :   Retrieved more than one CWS Item
- <span style="color:red">  316  </span> :   Retrieved more than one CWS Order FF Shipping Type
- <span style="color:red">  317  </span> :   Number of greeting messages exceeds card quantity
- <span style="color:red">  318  </span> :   Card ISO required
- <span style="color:red">  319  </span> :   Serial Number required
- <span style="color:red">  320  </span> :   Invalid ISO/Serial Number
- <span style="color:red">  321  </span> :   Customer new password required
- <span style="color:red">  322  </span> :   Invalid customer login
- <span style="color:red">  323  </span> :   Invalid customer login/email
- <span style="color:red">  324  </span> :   CWS Order shopping_cart empty
- <span style="color:red">  325  </span> :   Selected item(s) are currently out of stock
- <span style="color:red">  326  </span> :   Login is required
- <span style="color:red">  327  </span> :   Login is not a valid email address
- <span style="color:red">  328  </span> :   Invalid customer type
- <span style="color:red">  329  </span> :   Invalid expiry period
- <span style="color:red">  330  </span> :   Invalid token
- <span style="color:red">  331  </span> :   Gift already collected on YYYY-MM-DD HH:MM:SS
- <span style="color:red">  332  </span> :   Gift expired on YYYY-MM-DD
- <span style="color:red">  333  </span> :   CWS Bulk Ecert Order delivery method invalid
- <span style="color:red">  334  </span> :   CWS Bulk Ecert Order delivery ftp address invalid
- <span style="color:red">  335  </span> :   Customer Address Description required
- <span style="color:red">  336  </span> :   Customer Address ID required
- <span style="color:red">  337  </span> :   Invalid site
- <span style="color:red">  338  </span> :   Invalid address type
- <span style="color:red">  339  </span> :   Invalid Base points
- <span style="color:red">  340  </span> :   No customer orders found
- <span style="color:red">  341  </span> :   Setting favourite order failed
- <span style="color:red">  342  </span> :   Invalid Card Face ID
- <span style="color:red">  343  </span> :   Card Face ID required
- <span style="color:red">  344  </span> :   Preview image required
- <span style="color:red">  345  </span> :   Finalized print image required
- <span style="color:red">  346  </span> :   Bad user uploaded image base64 data
- <span style="color:red">  347  </span> :   Bad preview image base64 data
- <span style="color:red">  348  </span> :   Bad finalized image base64 data
- <span style="color:red">  349  </span> :   Error creating new CWS card image record
- <span style="color:red">  350  </span> :   Error updating CWS card image record
- <span style="color:red">  351  </span> :   No shipping methods found
- <span style="color:red">  352  </span> :   Invalid promo offer code
- <span style="color:red">  353  </span> :   CWS Order activation not allowed
- <span style="color:red">  354  </span> :   CWS Order already active
- <span style="color:red">  355  </span> :   CWS Order activation failed
- <span style="color:red">  356  </span> :   Customer has no access to activate orders
- <span style="color:red">  357  </span> :   Invalid payment type
- <span style="color:red">  358  </span> :   Customer ID required
- <span style="color:red">  359  </span> :   Invalid customer ID
- <span style="color:red">  360  </span> :   Additional Data missing or invalid
- <span style="color:red">  361  </span> :   User requesting the customer account update is not found
- <span style="color:red">  362  </span> :   Social Login is invalid
- <span style="color:red">  363  </span> :   Customer address already exists
- <span style="color:red">  364  </span> :   Card description is required
- <span style="color:red">  365  </span> :   Reload Type is not valid
- <span style="color:red">  366  </span> :   Reload Frequency is not valid
- <span style="color:red">  367  </span> :   Reload Amount is not valid
- <span style="color:red">  368  </span> :   Threshold Amount is not valid
- <span style="color:red">  369  </span> :   Credit Card Profile ID is not valid
- <span style="color:red">  370  </span> :   Custom Card Image ID is not valid
- <span style="color:red">  371  </span> :   Order type not valid for merchant.
- <span style="color:red">  372  </span> :   Item is not valid.
- <span style="color:red">  373  </span> :   Invalid Payment Amount.
- <span style="color:red">  374  </span> :   Online ordering not enabled for store.
- <span style="color:red">  375  </span> :   Invalid outlet id.
- <span style="color:red">  376  </span> :   Invalid Items List
- <span style="color:red">  377  </span> :   Invalid Item ID/SKU Code
- <span style="color:red">  378  </span> :   Invalid settings level.
- <span style="color:red">  379  </span> :   Invalid maximum rows
- <span style="color:red">  380  </span> :   Invalid starting position
- <span style="color:red">  381  </span> :   Pre-Auth already closed
- <span style="color:red">  382  </span> :   Payment Plan does not exist
- <span style="color:red">  383  </span> :   CWS Ecert Order declined - generation merchant is no longer grouped.
- <span style="color:red">  384  </span> :   Company ABN is required
- <span style="color:red">  385  </span> :   Company Name is required
- <span style="color:red">  386  </span> :   Valid Activation Code is required
- <span style="color:red">  387  </span> :   One and only one of Checkout Order/Shipping Order/Card Number required
- <span style="color:red">  388  </span> :   No valid promos found
- <span style="color:red">  389  </span> :   Pending Payment
- <span style="color:red">  390  </span> :   ERR remaining credit=$99.99
- <span style="color:red">  391  </span> :   ERR remaining shared balance=$99.99 (with actual balance)
- <span style="color:red">  392  </span> :   Reverse Sale/Setup Fee failed
- <span style="color:red">  393  </span> :   Custom Card Image has been removed
- <span style="color:red">  394  </span> :   Minimum 7 digits is required
- <span style="color:red">  395  </span> :   Invalid combo item
- <span style="color:red">  396  </span> :   Item is out of stock
- <span style="color:red">  397  </span> :   Invalid Bulk Job ID
- <span style="color:red">  398  </span> :   Duplicate Transactions found
- <span style="color:red">  399  </span> :   Government Identification cannot be updated while mapped to a card
- <span style="color:red">  400  </span> :   Phone Number cannot be updated while mapped to a card
- <span style="color:red">  401  </span> :   Invalid Table Number
- <span style="color:red">  402  </span> :   Invalid pickup template
- <span style="color:red">  403  </span> :   Balance of card is not up to date.
- <span style="color:red">  404  </span> :   Invalid CWS Skin.
- <span style="color:red">  405  </span> :   CWS Skin is not active.
- <span style="color:red">  406  </span> :   Invalid IP address
- <span style="color:red">  407  </span> :   New password must be different than existing password
- <span style="color:red">  408  </span> :   Transfer Type not valid
- <span style="color:red">  409  </span> :   Insufficient funds on ticket
- <span style="color:red">  410  </span> :   Insufficient funds in Patron Account
- <span style="color:red">  411  </span> :   Certificate is a shared coupon and is restricted from registration
- <span style="color:red">  412  </span> :   Invalid performance
- <span style="color:red">  413  </span> :   Invalid phone number
- <span style="color:red">  414  </span> :   Shipping option can only deliver to physical addresses.
- <span style="color:red">  415  </span> :   Temporary error. Please retry.
- <span style="color:red">  416  </span> :   Invalid Wallet Platform
- <span style="color:red">  426  </span> :   Payment due is negative, please re-input purchase details
- <span style="color:red">  435  </span> :   Ticket can be redeemed after this date only: 01/20/2020. bal=$99.99 (with actual data and balance)
- <span style="color:red">  442  </span> :   Invalid Promotional offer name
- <span style="color:red">  443  </span> :   Promotional offer name is not unique
- <span style="color:red">  444  </span> :   Promotional offer name does not exist
- <span style="color:red">  445  </span> :   Promotional offer key limit must be a number with no decimal
- <span style="color:red">  446  </span> :   Invalid Promotional offer key limit
- <span style="color:red">  447  </span> :   Promotional offer key limit must be a number
- <span style="color:red">  448  </span> :   Invalid Promotional offer arguments
- <span style="color:red">  449  </span> :   This code is already present: 10001 (with actual offer code)
- <span style="color:red">  455  </span> :   Event Date is not valid
- <span style="color:red">  456  </span> :   Event Promotion is not valid



## Values

| Name                          | Value                         |
| ----------------------------- | ----------------------------- |
| `OneHundred`                  | 100                           |
| `OneHundredAndOne`            | 101                           |
| `OneHundredAndTwo`            | 102                           |
| `OneHundredAndThree`          | 103                           |
| `OneHundredAndFour`           | 104                           |
| `OneHundredAndFive`           | 105                           |
| `OneHundredAndSix`            | 106                           |
| `OneHundredAndSeven`          | 107                           |
| `OneHundredAndEight`          | 108                           |
| `OneHundredAndNine`           | 109                           |
| `OneHundredAndTen`            | 110                           |
| `OneHundredAndEleven`         | 111                           |
| `OneHundredAndTwelve`         | 112                           |
| `OneHundredAndThirteen`       | 113                           |
| `OneHundredAndFourteen`       | 114                           |
| `OneHundredAndFifteen`        | 115                           |
| `OneHundredAndSixteen`        | 116                           |
| `OneHundredAndSeventeen`      | 117                           |
| `OneHundredAndEighteen`       | 118                           |
| `OneHundredAndNineteen`       | 119                           |
| `OneHundredAndTwenty`         | 120                           |
| `OneHundredAndTwentyOne`      | 121                           |
| `OneHundredAndTwentyTwo`      | 122                           |
| `OneHundredAndTwentyThree`    | 123                           |
| `OneHundredAndTwentyFour`     | 124                           |
| `OneHundredAndTwentyFive`     | 125                           |
| `OneHundredAndTwentySix`      | 126                           |
| `OneHundredAndTwentySeven`    | 127                           |
| `OneHundredAndTwentyEight`    | 128                           |
| `OneHundredAndTwentyNine`     | 129                           |
| `OneHundredAndThirty`         | 130                           |
| `OneHundredAndThirtyOne`      | 131                           |
| `OneHundredAndThirtyTwo`      | 132                           |
| `OneHundredAndThirtyThree`    | 133                           |
| `OneHundredAndThirtyFour`     | 134                           |
| `OneHundredAndThirtyFive`     | 135                           |
| `OneHundredAndThirtySix`      | 136                           |
| `OneHundredAndThirtySeven`    | 137                           |
| `OneHundredAndThirtyEight`    | 138                           |
| `OneHundredAndThirtyNine`     | 139                           |
| `OneHundredAndForty`          | 140                           |
| `OneHundredAndFortyOne`       | 141                           |
| `OneHundredAndFortyTwo`       | 142                           |
| `OneHundredAndFortyThree`     | 143                           |
| `OneHundredAndFortyFour`      | 144                           |
| `OneHundredAndFortyFive`      | 145                           |
| `OneHundredAndFortySix`       | 146                           |
| `OneHundredAndFortySeven`     | 147                           |
| `OneHundredAndFortyNine`      | 149                           |
| `OneHundredAndFifty`          | 150                           |
| `OneHundredAndFiftyOne`       | 151                           |
| `OneHundredAndFiftyTwo`       | 152                           |
| `OneHundredAndFiftyThree`     | 153                           |
| `OneHundredAndFiftyFour`      | 154                           |
| `OneHundredAndFiftyFive`      | 155                           |
| `OneHundredAndFiftySix`       | 156                           |
| `OneHundredAndFiftySeven`     | 157                           |
| `OneHundredAndFiftyEight`     | 158                           |
| `OneHundredAndFiftyNine`      | 159                           |
| `OneHundredAndSixty`          | 160                           |
| `OneHundredAndSixtyOne`       | 161                           |
| `OneHundredAndSixtyTwo`       | 162                           |
| `OneHundredAndSixtyThree`     | 163                           |
| `OneHundredAndSeventy`        | 170                           |
| `OneHundredAndSeventyFive`    | 175                           |
| `OneHundredAndSeventySix`     | 176                           |
| `OneHundredAndSeventySeven`   | 177                           |
| `OneHundredAndSeventyEight`   | 178                           |
| `OneHundredAndSeventyNine`    | 179                           |
| `OneHundredAndEighty`         | 180                           |
| `OneHundredAndEightyOne`      | 181                           |
| `OneHundredAndEightyTwo`      | 182                           |
| `OneHundredAndEightyThree`    | 183                           |
| `OneHundredAndEightyFour`     | 184                           |
| `OneHundredAndNinety`         | 190                           |
| `OneHundredAndNinetyOne`      | 191                           |
| `TwoHundredAndOne`            | 201                           |
| `TwoHundredAndTwo`            | 202                           |
| `TwoHundredAndThree`          | 203                           |
| `TwoHundredAndFour`           | 204                           |
| `TwoHundredAndTen`            | 210                           |
| `NineHundredAndNinetyNine`    | 999                           |
| `ZeroNB`                      | 0NB                           |
| `ZeroGB`                      | 0GB                           |
| `ZeroDB`                      | 0DB                           |
| `ZeroRB`                      | 0RB                           |
| `ZeroEB`                      | 0EB                           |
| `Zero`                        | 000                           |
| `One`                         | 001                           |
| `Two`                         | 002                           |
| `Three`                       | 003                           |
| `Four`                        | 004                           |
| `Five`                        | 005                           |
| `Six`                         | 006                           |
| `Seven`                       | 007                           |
| `Eight`                       | 008                           |
| `Ten`                         | 010                           |
| `Eleven`                      | 011                           |
| `Twelve`                      | 012                           |
| `Thirteen`                    | 013                           |
| `Fourteen`                    | 014                           |
| `Fifteen`                     | 015                           |
| `Nineteen`                    | 019                           |
| `TwentyOne`                   | 021                           |
| `TwentyEight`                 | 028                           |
| `ThirtyFour`                  | 034                           |
| `ThirtyNine`                  | 039                           |
| `FortyOne`                    | 041                           |
| `FortyThree`                  | 043                           |
| `FiftyOne`                    | 051                           |
| `FiftyTwo`                    | 052                           |
| `FiftyThree`                  | 053                           |
| `FiftyFour`                   | 054                           |
| `FiftyFive`                   | 055                           |
| `FiftySeven`                  | 057                           |
| `FiftyEight`                  | 058                           |
| `FiftyNine`                   | 059                           |
| `SixtyOne`                    | 061                           |
| `SixtyTwo`                    | 062                           |
| `SixtyThree`                  | 063                           |
| `SixtyFive`                   | 065                           |
| `SeventyFive`                 | 075                           |
| `SeventySix`                  | 076                           |
| `SeventySeven`                | 077                           |
| `SeventyEight`                | 078                           |
| `SeventyNine`                 | 079                           |
| `Eighty`                      | 080                           |
| `EightyOne`                   | 081                           |
| `EightyTwo`                   | 082                           |
| `EightyThree`                 | 083                           |
| `EightyFive`                  | 085                           |
| `EightySix`                   | 086                           |
| `NinetyOne`                   | 091                           |
| `NinetyTwo`                   | 092                           |
| `NinetyThree`                 | 093                           |
| `NinetyFour`                  | 094                           |
| `NinetySix`                   | 096                           |
| `ZeroA1`                      | 0A1                           |
| `ZeroA2`                      | 0A2                           |
| `ZeroA3`                      | 0A3                           |
| `ZeroB1`                      | 0B1                           |
| `ZeroB2`                      | 0B2                           |
| `ZeroCV`                      | 0CV                           |
| `ZeroD3`                      | 0D3                           |
| `ZeroE1`                      | 0E1                           |
| `ZeroE2`                      | 0E2                           |
| `ZeroE3`                      | 0E3                           |
| `ZeroEA`                      | 0EA                           |
| `ZeroEC`                      | 0EC                           |
| `ZeroHV`                      | 0HV                           |
| `ZeroK0`                      | 0K0                           |
| `ZeroK1`                      | 0K1                           |
| `ZeroK2`                      | 0K2                           |
| `ZeroK3`                      | 0K3                           |
| `ZeroM0`                      | 0M0                           |
| `ZeroN3`                      | 0N3                           |
| `ZeroN4`                      | 0N4                           |
| `ZeroN7`                      | 0N7                           |
| `ZeroR0`                      | 0R0                           |
| `ZeroR1`                      | 0R1                           |
| `ZeroT0`                      | 0T0                           |
| `ZeroT1`                      | 0T1                           |
| `ZeroT2`                      | 0T2                           |
| `ZeroT3`                      | 0T3                           |
| `ZeroT4`                      | 0T4                           |
| `ZeroT5`                      | 0T5                           |
| `ZeroT6`                      | 0T6                           |
| `ZeroT7`                      | 0T7                           |
| `ZeroV1`                      | 0V1                           |
| `OneHundredAndFortyEight`     | 148                           |
| `OneHundredAndSixtySix`       | 166                           |
| `OneHundredAndSixtySeven`     | 167                           |
| `OneHundredAndSixtyEight`     | 168                           |
| `OneHundredAndSixtyNine`      | 169                           |
| `OneHundredAndSeventyOne`     | 171                           |
| `OneHundredAndSeventyTwo`     | 172                           |
| `OneHundredAndSeventyThree`   | 173                           |
| `OneHundredAndSeventyFour`    | 174                           |
| `OneHundredAndEightyFive`     | 185                           |
| `OneHundredAndEightySix`      | 186                           |
| `OneHundredAndEightySeven`    | 187                           |
| `OneHundredAndEightyEight`    | 188                           |
| `OneHundredAndEightyNine`     | 189                           |
| `OneHundredAndNinetyTwo`      | 192                           |
| `OneHundredAndNinetyThree`    | 193                           |
| `OneHundredAndNinetyFour`     | 194                           |
| `OneHundredAndNinetyFive`     | 195                           |
| `OneHundredAndNinetySix`      | 196                           |
| `OneHundredAndNinetySeven`    | 197                           |
| `OneHundredAndNinetyEight`    | 198                           |
| `OneHundredAndNinetyNine`     | 199                           |
| `TwoHundred`                  | 200                           |
| `TwoHundredAndFive`           | 205                           |
| `TwoHundredAndSix`            | 206                           |
| `TwoHundredAndSeven`          | 207                           |
| `TwoHundredAndEight`          | 208                           |
| `TwoHundredAndNine`           | 209                           |
| `TwoHundredAndEleven`         | 211                           |
| `TwoHundredAndTwelve`         | 212                           |
| `TwoHundredAndThirteen`       | 213                           |
| `TwoHundredAndFourteen`       | 214                           |
| `TwoHundredAndFifteen`        | 215                           |
| `TwoHundredAndSixteen`        | 216                           |
| `TwoHundredAndSeventeen`      | 217                           |
| `TwoHundredAndEighteen`       | 218                           |
| `TwoHundredAndNineteen`       | 219                           |
| `TwoHundredAndTwenty`         | 220                           |
| `TwoHundredAndTwentyOne`      | 221                           |
| `TwoHundredAndTwentyTwo`      | 222                           |
| `TwoHundredAndTwentyThree`    | 223                           |
| `TwoHundredAndTwentyFour`     | 224                           |
| `TwoHundredAndTwentyFive`     | 225                           |
| `TwoHundredAndTwentySix`      | 226                           |
| `TwoHundredAndTwentySeven`    | 227                           |
| `TwoHundredAndTwentyEight`    | 228                           |
| `TwoHundredAndThirtyOne`      | 231                           |
| `TwoHundredAndThirtyTwo`      | 232                           |
| `TwoHundredAndThirtyThree`    | 233                           |
| `TwoHundredAndThirtyFour`     | 234                           |
| `TwoHundredAndThirtyFive`     | 235                           |
| `TwoHundredAndThirtySix`      | 236                           |
| `TwoHundredAndThirtySeven`    | 237                           |
| `TwoHundredAndThirtyEight`    | 238                           |
| `TwoHundredAndThirtyNine`     | 239                           |
| `TwoHundredAndForty`          | 240                           |
| `TwoHundredAndFortyOne`       | 241                           |
| `TwoHundredAndFortyTwo`       | 242                           |
| `TwoHundredAndFortyThree`     | 243                           |
| `TwoHundredAndFortyFour`      | 244                           |
| `TwoHundredAndFortyFive`      | 245                           |
| `TwoHundredAndFortySix`       | 246                           |
| `TwoHundredAndFortySeven`     | 247                           |
| `TwoHundredAndFortyEight`     | 248                           |
| `TwoHundredAndFortyNine`      | 249                           |
| `TwoHundredAndFifty`          | 250                           |
| `TwoHundredAndFiftyOne`       | 251                           |
| `TwoHundredAndFiftyTwo`       | 252                           |
| `TwoHundredAndFiftyThree`     | 253                           |
| `TwoHundredAndFiftyFour`      | 254                           |
| `TwoHundredAndFiftyFive`      | 255                           |
| `TwoHundredAndFiftySix`       | 256                           |
| `TwoHundredAndFiftySeven`     | 257                           |
| `TwoHundredAndFiftyEight`     | 258                           |
| `TwoHundredAndFiftyNine`      | 259                           |
| `TwoHundredAndSixty`          | 260                           |
| `TwoHundredAndSixtyOne`       | 261                           |
| `TwoHundredAndSixtyTwo`       | 262                           |
| `TwoHundredAndSixtyThree`     | 263                           |
| `TwoHundredAndSixtyFour`      | 264                           |
| `TwoHundredAndSixtyFive`      | 265                           |
| `TwoHundredAndSixtySix`       | 266                           |
| `TwoHundredAndSixtySeven`     | 267                           |
| `TwoHundredAndSixtyEight`     | 268                           |
| `TwoHundredAndSixtyNine`      | 269                           |
| `TwoHundredAndSeventy`        | 270                           |
| `TwoHundredAndSeventyOne`     | 271                           |
| `TwoHundredAndSeventyTwo`     | 272                           |
| `TwoHundredAndSeventyThree`   | 273                           |
| `TwoHundredAndSeventyFour`    | 274                           |
| `TwoHundredAndSeventyFive`    | 275                           |
| `TwoHundredAndSeventySix`     | 276                           |
| `TwoHundredAndSeventySeven`   | 277                           |
| `TwoHundredAndSeventyEight`   | 278                           |
| `TwoHundredAndSeventyNine`    | 279                           |
| `TwoHundredAndEighty`         | 280                           |
| `TwoHundredAndEightyOne`      | 281                           |
| `TwoHundredAndEightyTwo`      | 282                           |
| `TwoHundredAndEightyThree`    | 283                           |
| `TwoHundredAndEightyFour`     | 284                           |
| `TwoHundredAndEightyFive`     | 285                           |
| `TwoHundredAndEightySix`      | 286                           |
| `TwoHundredAndEightySeven`    | 287                           |
| `TwoHundredAndEightyEight`    | 288                           |
| `TwoHundredAndEightyNine`     | 289                           |
| `TwoHundredAndNinety`         | 290                           |
| `TwoHundredAndNinetyOne`      | 291                           |
| `TwoHundredAndNinetyTwo`      | 292                           |
| `TwoHundredAndNinetyThree`    | 293                           |
| `TwoHundredAndNinetyFour`     | 294                           |
| `TwoHundredAndNinetyFive`     | 295                           |
| `TwoHundredAndNinetySix`      | 296                           |
| `TwoHundredAndNinetySeven`    | 297                           |
| `TwoHundredAndNinetyEight`    | 298                           |
| `TwoHundredAndNinetyNine`     | 299                           |
| `ThreeHundred`                | 300                           |
| `ThreeHundredAndTwo`          | 302                           |
| `ThreeHundredAndThree`        | 303                           |
| `ThreeHundredAndFour`         | 304                           |
| `ThreeHundredAndFive`         | 305                           |
| `ThreeHundredAndSix`          | 306                           |
| `ThreeHundredAndSeven`        | 307                           |
| `ThreeHundredAndEight`        | 308                           |
| `ThreeHundredAndNine`         | 309                           |
| `ThreeHundredAndTen`          | 310                           |
| `ThreeHundredAndEleven`       | 311                           |
| `ThreeHundredAndTwelve`       | 312                           |
| `ThreeHundredAndThirteen`     | 313                           |
| `ThreeHundredAndFourteen`     | 314                           |
| `ThreeHundredAndFifteen`      | 315                           |
| `ThreeHundredAndSixteen`      | 316                           |
| `ThreeHundredAndSeventeen`    | 317                           |
| `ThreeHundredAndEighteen`     | 318                           |
| `ThreeHundredAndNineteen`     | 319                           |
| `ThreeHundredAndTwenty`       | 320                           |
| `ThreeHundredAndTwentyOne`    | 321                           |
| `ThreeHundredAndTwentyTwo`    | 322                           |
| `ThreeHundredAndTwentyThree`  | 323                           |
| `ThreeHundredAndTwentyFour`   | 324                           |
| `ThreeHundredAndTwentyFive`   | 325                           |
| `ThreeHundredAndTwentySix`    | 326                           |
| `ThreeHundredAndTwentySeven`  | 327                           |
| `ThreeHundredAndTwentyEight`  | 328                           |
| `ThreeHundredAndTwentyNine`   | 329                           |
| `ThreeHundredAndThirty`       | 330                           |
| `ThreeHundredAndThirtyOne`    | 331                           |
| `ThreeHundredAndThirtyTwo`    | 332                           |
| `ThreeHundredAndThirtyThree`  | 333                           |
| `ThreeHundredAndThirtyFour`   | 334                           |
| `ThreeHundredAndThirtyFive`   | 335                           |
| `ThreeHundredAndThirtySix`    | 336                           |
| `ThreeHundredAndThirtySeven`  | 337                           |
| `ThreeHundredAndThirtyEight`  | 338                           |
| `ThreeHundredAndThirtyNine`   | 339                           |
| `ThreeHundredAndForty`        | 340                           |
| `ThreeHundredAndFortyOne`     | 341                           |
| `ThreeHundredAndFortyTwo`     | 342                           |
| `ThreeHundredAndFortyThree`   | 343                           |
| `ThreeHundredAndFortyFour`    | 344                           |
| `ThreeHundredAndFortyFive`    | 345                           |
| `ThreeHundredAndFortySix`     | 346                           |
| `ThreeHundredAndFortySeven`   | 347                           |
| `ThreeHundredAndFortyEight`   | 348                           |
| `ThreeHundredAndFortyNine`    | 349                           |
| `ThreeHundredAndFifty`        | 350                           |
| `ThreeHundredAndFiftyOne`     | 351                           |
| `ThreeHundredAndFiftyTwo`     | 352                           |
| `ThreeHundredAndFiftyThree`   | 353                           |
| `ThreeHundredAndFiftyFour`    | 354                           |
| `ThreeHundredAndFiftyFive`    | 355                           |
| `ThreeHundredAndFiftySix`     | 356                           |
| `ThreeHundredAndFiftySeven`   | 357                           |
| `ThreeHundredAndFiftyEight`   | 358                           |
| `ThreeHundredAndFiftyNine`    | 359                           |
| `ThreeHundredAndSixty`        | 360                           |
| `ThreeHundredAndSixtyOne`     | 361                           |
| `ThreeHundredAndSixtyTwo`     | 362                           |
| `ThreeHundredAndSixtyThree`   | 363                           |
| `ThreeHundredAndSixtyFour`    | 364                           |
| `ThreeHundredAndSixtyFive`    | 365                           |
| `ThreeHundredAndSixtySix`     | 366                           |
| `ThreeHundredAndSixtySeven`   | 367                           |
| `ThreeHundredAndSixtyEight`   | 368                           |
| `ThreeHundredAndSixtyNine`    | 369                           |
| `ThreeHundredAndSeventy`      | 370                           |
| `ThreeHundredAndSeventyOne`   | 371                           |
| `ThreeHundredAndSeventyTwo`   | 372                           |
| `ThreeHundredAndSeventyThree` | 373                           |
| `ThreeHundredAndSeventyFour`  | 374                           |
| `ThreeHundredAndSeventyFive`  | 375                           |
| `ThreeHundredAndSeventySix`   | 376                           |
| `ThreeHundredAndSeventySeven` | 377                           |
| `ThreeHundredAndSeventyEight` | 378                           |
| `ThreeHundredAndSeventyNine`  | 379                           |
| `ThreeHundredAndEighty`       | 380                           |
| `ThreeHundredAndEightyOne`    | 381                           |
| `ThreeHundredAndEightyTwo`    | 382                           |
| `ThreeHundredAndEightyThree`  | 383                           |
| `ThreeHundredAndEightyFour`   | 384                           |
| `ThreeHundredAndEightyFive`   | 385                           |
| `ThreeHundredAndEightySix`    | 386                           |
| `ThreeHundredAndEightySeven`  | 387                           |
| `ThreeHundredAndEightyEight`  | 388                           |
| `ThreeHundredAndEightyNine`   | 389                           |
| `ThreeHundredAndNinety`       | 390                           |
| `ThreeHundredAndNinetyOne`    | 391                           |
| `ThreeHundredAndNinetyTwo`    | 392                           |
| `ThreeHundredAndNinetyThree`  | 393                           |
| `ThreeHundredAndNinetyFour`   | 394                           |
| `ThreeHundredAndNinetyFive`   | 395                           |
| `ThreeHundredAndNinetySix`    | 396                           |
| `ThreeHundredAndNinetySeven`  | 397                           |
| `ThreeHundredAndNinetyEight`  | 398                           |
| `ThreeHundredAndNinetyNine`   | 399                           |
| `FourHundred`                 | 400                           |
| `FourHundredAndOne`           | 401                           |
| `FourHundredAndTwo`           | 402                           |
| `FourHundredAndThree`         | 403                           |
| `FourHundredAndFour`          | 404                           |
| `FourHundredAndFive`          | 405                           |
| `FourHundredAndSix`           | 406                           |
| `FourHundredAndSeven`         | 407                           |
| `FourHundredAndEight`         | 408                           |
| `FourHundredAndNine`          | 409                           |
| `FourHundredAndTen`           | 410                           |
| `FourHundredAndEleven`        | 411                           |
| `FourHundredAndTwelve`        | 412                           |
| `FourHundredAndThirteen`      | 413                           |
| `FourHundredAndFourteen`      | 414                           |
| `FourHundredAndFifteen`       | 415                           |
| `FourHundredAndSixteen`       | 416                           |
| `FourHundredAndTwentySix`     | 426                           |
| `FourHundredAndThirtyFive`    | 435                           |
| `FourHundredAndFortyTwo`      | 442                           |
| `FourHundredAndFortyThree`    | 443                           |
| `FourHundredAndFortyFour`     | 444                           |
| `FourHundredAndFortyFive`     | 445                           |
| `FourHundredAndFortySix`      | 446                           |
| `FourHundredAndFortySeven`    | 447                           |
| `FourHundredAndFortyEight`    | 448                           |
| `FourHundredAndFortyNine`     | 449                           |
| `FourHundredAndFiftyFive`     | 455                           |
| `FourHundredAndFiftySix`      | 456                           |