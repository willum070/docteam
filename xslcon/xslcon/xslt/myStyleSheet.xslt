<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="/">
        <xsl:element name="UI">
            <xsl:element name="methods">
                <xsl:for-each select="doc/members/member">
                    <xsl:element name="MethodName">
                        <xsl:value-of select="@name" />
                    </xsl:element>
                    <xsl:element name="Synopsis">
                        <xsl:value-of select="summary"/>
                        <xsl:value-of select="para"/>
                    </xsl:element>
                    <xsl:element name="HTTPMethod"></xsl:element>
                    <xsl:element name="URI">/</xsl:element>
                    <xsl:element name="RequiresOAuth">N</xsl:element>
                    <xsl:element name="parameters">
                        <xsl:for-each select="param">
                            <xsl:element name="Name">
                                <xsl:value-of select="@name"/>
                            </xsl:element>
                            <xsl:element name="Required">Y</xsl:element>
                            <xsl:element name="Default">.</xsl:element>
                            <xsl:element name="Type">string</xsl:element>
                            <xsl:element name="Description">
                                <xsl:value-of select="param"/>
                            </xsl:element>
                        </xsl:for-each>
                    </xsl:element>                  
                </xsl:for-each>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    
</xsl:stylesheet>
